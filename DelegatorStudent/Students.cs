using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorStudent
{
    internal class Students
    {
        private List<Student> listOfStudent = new List<Student>();

        public delegate void printProcess(Student student);

        public void Add(Student student)
        {
            listOfStudent.Add(student);
        }
        public void Print()
        {
            Print((student) =>
            {
                Console.WriteLine(student);
            });

        }

        public void Print(printProcess process)
        {
            listOfStudent.ForEach((s) => process(s));

/*            foreach (var item in listOfStudent)
            {
                process(item);
            }*/
        }
    }
}
