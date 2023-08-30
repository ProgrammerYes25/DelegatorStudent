using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorStudent
{
    internal class DelegatorStudent
    {
        

        static void Main(string[] args)
        {
            Students students = new Students();
            students.Add(new Student("정가현", 4.5));
            students.Add(new Student("임수연", 4.6));

            students.Print();
            students.Print((student) =>
            {
                Console.WriteLine();
                Console.WriteLine("이름 : " + student.Name);
                Console.WriteLine("학점 : " + student.Score);
            });
        }
    }
}
