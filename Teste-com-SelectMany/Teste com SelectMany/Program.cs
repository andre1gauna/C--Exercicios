using System;
using System.Linq;

namespace Teste_com_SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Student.GetAllStudetns().SelectMany(s => s.Subjects, (student, subject) =>
            new { StudentName = student.Name, Subject = subject });

            foreach (var v in result)
            {
                Console.WriteLine(v.StudentName + " - " + v.Subject);
            }
        }
    }
}
