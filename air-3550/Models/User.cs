using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserType { get; set; }
        public string PasswordHash { get; set; }

    }
}
