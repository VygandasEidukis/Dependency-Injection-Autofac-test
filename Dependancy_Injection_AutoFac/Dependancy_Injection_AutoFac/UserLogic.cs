using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Injection_AutoFac
{
    public class UserLogic : IUserLogic
    {
        public ILogger _Logger { get; set; }

        public UserLogic(ILogger logger)
        {
            _Logger = logger;
        }

        public void RegisterUser(UserModel user)
        {
            Console.WriteLine($"{user.Name} {user.LastName}");

            _Logger.Log($"Registered user: {user.Name}");
        }
    }
}
