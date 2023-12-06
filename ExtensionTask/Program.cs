
#region task1 

using ExtensionTask.Domain.Models;
using ExtensionTask.Helper.ErrorMessages;
using System.Text.RegularExpressions;

User user1 = new User("user1@gmail.com", "Password1");
user1.ShowInfo();


User user2 = new("user2@gmail.com", "Password2");
user2.ShowInfo();


User user3 = new("user3@gmail.com", "assw3.ord3");

user3.ShowInfo();

#endregion



Console.WriteLine("------------------------------------------------------------------");
#region task2
Student student1 = new("Cəlil Cəlilov", 86);
student1.StudentInfo();

Student student2 = new("Qismət Fərəcli",61);
student2.StudentInfo();



Student student3 = new("Əlipaşa İsazadə",50);
student3.StudentInfo();

#endregion






    