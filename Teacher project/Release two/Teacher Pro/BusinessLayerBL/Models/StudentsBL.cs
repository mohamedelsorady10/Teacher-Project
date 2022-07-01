using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBL.Models
{
    public class StudentsBL
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentMobile { get; set; }
        public string ParentMobile { get; set; }
        public string StudentAddress { get; set; }
        public string Notes { get; set; }
        public int GroupId { get; set; }
    }
}
