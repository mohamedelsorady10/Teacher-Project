using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBL.Models
{
    public class BookletsBL
    {
        public int BookletID { get; set; }
        public string BookletName { get; set; }
        public int StudentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal PaymentRemainder { get; set; }

    }
}
