using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class Agreement
    {
        public int Id { get; set; }       
        public string Description { get; set; }
        public double DiscountValue { get; set; }
        public double PercentValue { get; set; }
    }
}
