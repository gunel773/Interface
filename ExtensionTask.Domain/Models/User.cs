using ExtensionTask.Domain.Interface;
using ExtensionTask.Helper.ErrorMessages;
using System.Text.RegularExpressions;


namespace ExtensionTask.Domain.Models
{
    public class User : IAccount
    {


        public int Id { get; set; }
        private static int _id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;
        public string Password
        {
            get
            { return _password; }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                    Console.WriteLine(ErrorMessages.SuccessMessage);
                }
                else
                {
                    Console.WriteLine(ErrorMessages.FailMessage);
                }

            }

        }

       

        public User(string email, string password)
        {
            _id++;
            Id = _id;

            Email = email;
            Password = password;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Giris edir: USER:ID: {Id}, Fullname:{Fullname}, Email:{Email}");
        }

        public bool PasswordChecker(string password)
        {

            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$");
            return regex.IsMatch(password);

        }
    }


   
}
