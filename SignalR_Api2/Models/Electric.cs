using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Api2.Models
{
    public enum ECity
    {
        istanbul=1,
        ankara=2,
        izmir=3,
        konya=4,
        trabzon=5
    }
    public class Electric
    {
        public int ElectricID { get; set; }
        public ECity City { get; set; }
        public int Count { get; set; }
        public DateTime ElectricDate { get; set; }
    }
}
