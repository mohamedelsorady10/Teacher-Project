using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBL.Models
{
    public  class SysUsers
    {
        public static bool _IsAdmin { get; set; }
        public static readonly List<User> UsersList =new List<User>();
        public static void SetUsers()
        {
            UsersList.Add(new User { UserName = "mohamed", Password = "123", IsAdmin = true });
            UsersList.Add(new User { UserName = "ahmed", Password = "123", IsAdmin = false });
        }
        
      
    }
    public class User
    {
        public string  UserName { get; set; }
        public string Password{ get; set; }
        public bool IsAdmin { get; set; }
    }
}
