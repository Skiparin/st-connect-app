using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.DTOClasses
{
    class UserDTO
    {
        public String email { get; set; }
        public String password { get; set; }
        public String password_confirmation { get; set; }

        public UserDTO( String email, String password, String password_confirmation)
        {
            this.email = email;
            this.password = password;
            this.password_confirmation = password_confirmation;
        }
    }
}
