

namespace ExtensionTask.Domain.Interface
{
    public interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
