using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Models.Models;
using WindowsApp.BLL.BLL;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager _studentManager = new StudentManager();

            Student student = new Student();
            student.ID = 100;
            student.Name = "Asad";

            Console.WriteLine(_studentManager.AddStudent(student));
            Console.ReadKey();

        }
    }
}
