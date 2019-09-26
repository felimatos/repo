using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto
{
    public class RateDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double DailyRate { get; set; }
        public double OvernightValue { get; set; }
        public double PeriodValue { get; set; }
    }
}
