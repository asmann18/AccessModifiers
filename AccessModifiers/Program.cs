using AccessModifiers.Models;
using AccessModifiers.Services;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Employee employee = new Employee("Asiman",true,100);
            Assistant.GetFeedBack(employee);
            Assistant.GetFeedBack(employee);
            Assistant.GetFeedBack(employee);
            Console.WriteLine(employee.Salary);
        }
        public static Student CreateStudent()
        {
        restart:
            Console.WriteLine("Name daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Yas daxil edin");
            bool isParse = byte.TryParse(Console.ReadLine(), out byte age);
            Console.WriteLine("Bal daxil edin");
            bool isParseGrade = byte.TryParse(Console.ReadLine(), out byte grade);
            if (!isParse || !isParseGrade)
            {
                Console.WriteLine("duzgun ededler daxil edin");
                goto restart;
            }
            Student student = new(name, age, grade);
            if (student.Age == 101 || student.Grade == 101 || student.Name is null)
            {
                goto restart;
            }
            return student;
        }
    }
}