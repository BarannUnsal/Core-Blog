using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }
        public string NotificationType { get; set; }
        public string NotificationSymbol { get; set; }
        public string NotificationDetails { get; set; }
        public bool NotificationStatus { get; set; }
        public string NotifictaionColor { get; set; }
        public DateTime NotificationDate { get; set; }
    }
}
