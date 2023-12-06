

namespace ExtensionTask.Domain.Models
{


    public class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Point { get; set; }
        private static int _id { get; set; }

        public Student(string fullname, int point)
        {
            _id++;
            Id = _id;
            Point = point;
            Fullname = fullname;

        }

        public void StudentInfo()
        {
            Console.WriteLine($"Şagird haqqında melumat: USER:ID: {Id}, Fullname:{Fullname}, Point:{Point}");
        }


    }
}
