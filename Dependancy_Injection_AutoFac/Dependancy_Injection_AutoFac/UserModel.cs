using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Injection_AutoFac
{
    public class UserModel : IUserModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public UserModel(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}
