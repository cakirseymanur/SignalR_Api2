using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Api2.Models
{
    public class ElectricChart
    {
        public ElectricChart()
        {
            Counts = new List<int>();
        }
        public string ElectricDate { get; set; }
        public List<int> Counts { get; set; }
    }
}
