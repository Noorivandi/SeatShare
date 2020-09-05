using Exir.Framework.Common;
using Exir.Framework.DataAccess;
using Exir.Framework.DataAccess.EntityFramework;
using SeatDomain.Dal;
using SeatDomain.Models;
using SeatDomain.Repository.UserDefinedTableTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatDomain.Repository
{
    public interface IClientTypeRepository : IReadOnlyClientTypeRepository
    {
    }
    public interface IReadOnlyClientTypeRepository : IRepository<ClientType>
    {
        List<ClientType> GetLastClientTypes(IEnumerable<long> insCodes, DateTime dayDt);
    }
    public class ClientTypeRepository : EntityFrameworkRepository<ClientType>, IClientTypeRepository
    {
        public List<ClientType> GetLastClientTypes(IEnumerable<long> insCodes, DateTime dayDt)
        {
            var parameters = new[] {
                dayDt.ToSqlParameter("dayDt"),
                insCodes.Select(x => new BigIntList(x)).ToList().ToSqlParameter("insCodes"),
            };

            var ctx = Context as SeatDBEntitiesDbContext;
            return ctx.ExecuteStoredProcedure("sp_get_last_client_types", parameters).ToList<ClientType>();
        }
    }
}
