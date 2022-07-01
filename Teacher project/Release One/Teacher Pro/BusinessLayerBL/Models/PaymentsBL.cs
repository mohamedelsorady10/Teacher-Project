using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBL.Models
{
    public class PaymentsBL
    {
        public int PaymentId { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int StudentId { get; set; }
        public decimal PaymentRemainder { get; set; }
    }
}
