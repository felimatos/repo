using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class Rate
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double DayValue { get; set; }
        public double NightStayValue { get; set; }
        public double NightStayFracValue { get; set; }
        
    }
}
