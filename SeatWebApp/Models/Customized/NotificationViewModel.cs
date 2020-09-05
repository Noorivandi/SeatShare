namespace SeatWebApp.Models
{
    using Exir.Framework.Common;
    using Exir.Framework.Uie.Adapter;
    using Exir.Framework.Uie.Bocrud;
    using SeatDomain.Models;
    using SeatDomain.Services;
    using SeatWebApp.Services;
    using System;
    public partial class NotificationViewModel : EntityViewModel<Notification>
    {
        public NotificationViewModel(object obj, string pk, Type pkType, string version)
            : base(obj, nameof(Notification.NotificationPK), typeof(int), null, isKeyIdentity: true)
        {
        }
        public NotificationViewModel(Notification obj)
            : base(obj)
        {
        }

        
    }

}
