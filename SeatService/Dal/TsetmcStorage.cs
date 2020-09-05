using Exir.Framework.Common;
using Exir.Framework.Common.Logging;
using Exir.Framework.Security.ObjectValidation;
using SeatDomain;
using SeatDomain.Dal;
using SeatDomain.Models;
using SeatService.SeatServiceEngine.DataProvider.Tsetmc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Seat.DataStore
{
    public class TsetmcStorage : ITsetmcStorage
    {
        private ILogger _logger;

        public TsetmcStorage()
        {
            _logger = LogManager.Instance.GetLogger<TsetmcStorage>();
        }

        private SeatDBEntitiesDbContext _createContext()
        {
            return new SeatDBEntitiesDbContext("SeatDB", "LocalSqlServer");
        }

        public async Task<List<Instrument>> GetAllInstrumentsAsync()
        {
            using (var ctx = _createContext())
            {
                return await ctx.Set<Instrument>().AsNoTracking().ToListAsync();
            }
        }

        public async Task<ObserverMessage> GetLastMessageAsync()
        {
            using (var ctx = _createContext())
            {
                var msg = await ctx.Set<Message>().OrderByDescending(x => x.MessagePK).FirstOrDefaultAsync();

                if (msg != null)
                    return new ObserverMessage
                    {
                        Description = msg.Description,
                        MessageDt = msg.MessageDt,
                        Subject = msg.Subject
                    };
                return null;
            }
        }

        public async Task<CodalMessage> GetLastCodalMessageAsync()
        {
            using (var ctx = _createContext())
            {
                return await ctx.Set<CodalMessage>().OrderByDescending(x => x.TracingNo).FirstOrDefaultAsync();
            }
        }

        public async Task<int> SaveMessagesAsync(IEnumerable<CodalMessage> codalMessages)
        {
            using (var ctx = _createContext())
            {
                var tracing_no = codalMessages.Select(x => x.TracingNo).ToArray();
                var exists = ctx.Set<CodalMessage>().Where(x => tracing_no.Contains(x.TracingNo)).Select(x => x.TracingNo).ToArray();

                var msgs = codalMessages
                    .Where(x => !exists.Contains(x.TracingNo))
                    .Select(x => new CodalMessage
                    {
                        CompanyName = x.CompanyName.MaxLength(100),
                        InsCode = x.InsCode,
                        PublishDateTime = x.PublishDateTime,
                        SentDateTime = x.SentDateTime,
                        Symbol = x.Symbol.MaxLength(100),
                        Title = x.Title.MaxLength(1500, true),
                        TracingNo = x.TracingNo
                    });

                ctx.Set<CodalMessage>().AddRange(msgs);

                return await ctx.SaveChangesAsync();
            }
        }

        public async Task<int> SaveMessagesAsync(IEnumerable<ObserverMessage> observerMessages)
        {
            using (var ctx = _createContext())
            {
                Dictionary<long, Instrument> attached_instances = new Dictionary<long, Instrument>();
                foreach (var obmsg in observerMessages)
                {
                    var msg = new Message
                    {
                        Description = obmsg.Description,
                        MessageDt = obmsg.MessageDt,
                        Subject = obmsg.Subject,
                    };
                    if (obmsg.RelativeInstances != null)
                    {
                        if (obmsg.RelativeInstances.Count == 1)
                            msg.InsCode = obmsg.RelativeInstances[0];
                        else
                            foreach (var icode in obmsg.RelativeInstances.Distinct())
                            {
                                if (!attached_instances.ContainsKey(icode))
                                {
                                    var ins = new Instrument
                                    {
                                        InsCode = icode
                                    };
                                    ctx.Entry(ins).State = System.Data.Entity.EntityState.Unchanged;
                                    attached_instances.Add(icode, ins);
                                }
                                var instance = attached_instances[icode];
                                msg.Instruments.Add(instance);
                            }
                    }
                    ctx.Set<Message>().Add(msg);
                }

                if (observerMessages.Any())
                    _logger.InfoFormat("successfuly {0} observer message was saved in database", observerMessages.Count());

                return await ctx.SaveChangesAsync();
            }
        }

        public async Task UpdateInstancesAsync(IEnumerable<Instrument> instruments)
        {
            var ov = ObjectRegistry.GetObject<IValidationProvider>();

            using (var ctx = _createContext())
            {
                int added = 0, modified = 0;
                var valids = instruments.Where(x => ov.Validate<Instrument>(x, Mode.OnUpdate + "," + Mode.OnInsert).IsValid).ToList();
                var sample = valids.First();
                var fields = sample.GetFields().Where(x => x.Kind == FieldKinds.Primitive);
                for (var i = 0; i < valids.Count; ++i)
                {
                    var instrument = valids[i];
                    instrument.Type = (byte)instrument.InstrumentType;

                    if (instrument.ChangeTracker.State == ObjectState.Added)
                    {
                        ctx.Set<Instrument>().Add(instrument);
                        ++added;
                        continue;
                    }

                    if (instrument.ChangeTracker.State == ObjectState.Modified)
                    {
                        modified++;
                        var entry = ctx.Entry(instrument);
                        entry.State = EntityState.Modified;

                        if (instrument.ChangeTracker.ChangedProperties.Count > 0)
                        {
                            foreach (var p in fields)
                                entry.Property(p.Name).IsModified = false;

                            foreach (var ch in instrument.ChangeTracker.ChangedProperties)
                                entry.Property(ch).IsModified = true;
                        }
                    }
                }
                var changeCount = await ctx.SaveChangesAsync();

                _logger.InfoFormat("successfuly {0} ins was updated and {1} ins was added", modified, added);

                foreach (var instrument in instruments)
                    instrument.ResetChanges();
            }
        }

        public async Task AddHistoryAsync(List<History> lists)
        {
            using (var ctx = _createContext())
            {
                ctx.Set<History>().AddRange(lists);

                var changeCount = await ctx.SaveChangesAsync();

                _logger.InfoFormat("successfuly {0} history was updated", changeCount);

            }
        }

        public async Task<Dictionary<long, int>> GetLastDevensAsync()
        {
            using (var ctx = _createContext())
            {
                var lastOnes = await ctx.Set<History>()
                    .GroupBy(x => x.InsCode)
                    .Select(x => new
                    {
                        x.Key,
                        MaxDeven = x.Max(y => y.DEven)
                    })
                    .ToListAsync();

                var result = new Dictionary<long, int>();
                result.AddRange(lastOnes.Select(x => new KeyValuePair<long, int>(x.Key, x.MaxDeven)));
                return result;
            }
        }
    }
}
