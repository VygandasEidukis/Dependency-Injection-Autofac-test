using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Injection_AutoFac
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadContainers();
            var container = LoadContainers();

            using(var scope = container.BeginLifetimeScope())
            {
                UserModel user = new UserModel("Vygandas", "Eidukis");
                var userLogic = scope.Resolve<IUserLogic>();
                userLogic.RegisterUser(user);
            }

            Console.ReadKey();
        }

        static IContainer LoadContainers()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UserModel>().As<IUserModel>();
            builder.RegisterType<UserLogic>().As<IUserLogic>();
            builder.RegisterInstance(new Logger()).As<ILogger>();
            builder.RegisterType<Logger>().As<ILogger>();

            var container = builder.Build();

            return container;
        }
    }
}
