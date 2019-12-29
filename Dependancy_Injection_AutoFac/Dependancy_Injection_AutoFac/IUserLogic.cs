namespace Dependancy_Injection_AutoFac
{
    public interface IUserLogic
    {
        ILogger _Logger { get; set; }

        void RegisterUser(UserModel user);
    }
}