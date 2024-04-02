using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public bool IsStudent { get; set; }
        public bool IsWorking { get; set; }

        public Person(string name, int age, string gender, string birthDate, bool isStudent, bool isWorking)
        {
            Name = name;
            Age = age;
            Gender = gender;
            BirthDate = birthDate;
            IsStudent = isStudent;
            IsWorking = isWorking;
        }

        public void Work()
        {
            Console.WriteLine("Людина працює");
        }

        public void Relax()
        {
            Console.WriteLine("Людина відпочиває");
        }

        public void Healing()
        {
            Console.WriteLine("Людина лікується");
        }
    }
}