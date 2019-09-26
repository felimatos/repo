using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class AssociateDto
    {
        public int Id { get; set; }
        public int VacancyQuantity { get; set; }
        public int CustomerId { get; set; }
        public int AgreementId { get; set; }
        public int RateId { get; set; }
    }
}
