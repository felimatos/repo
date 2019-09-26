using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto
{
    public class AgreementDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal DiscountAmmount { get; set; }
        public decimal DiscountPercentual { get; set; }
    }
}
