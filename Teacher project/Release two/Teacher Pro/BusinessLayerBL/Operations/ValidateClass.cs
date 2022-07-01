using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBL.Operations
{
   public static class ValidateClass
    {
        
        private readonly static string _mac = ",F0761CB21595,E4F89C4132E7,E6F89C4132E6,E4F89C4132E6,";
        public static bool Validate()
        {
            //string mac = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault().
            //    GetPhysicalAddress().ToString();

            //if (_mac.Contains($",{mac},"))
            //    return true;
            //else
            //    return false;
            return true;
        }
    }
}
