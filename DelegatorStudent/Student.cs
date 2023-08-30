using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorStudent
{
    internal class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public Student(string Name, double Scoer) { 
            this.Name = Name;
            this.Score = Scoer;
        }
        public override string ToString()
        {
            return this.Name+" :"+this.Score;
        }
    }
}
