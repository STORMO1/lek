using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    internal class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birth { get; set; }
        public string TypeOfAnimal { get; set; }
        public bool Deffects { get; set; }
        public bool IsTrained { get; set; }
        public string Breed { get; set; }

        public Animal(string name, int age, string typeofanimal, string birth, bool deffects, bool isTrained, string breed)
        {
            Name = name;
            Age = age;
            TypeOfAnimal = typeofanimal;
            Birth = birth;
            Deffects = deffects;
            IsTrained = isTrained;
            Breed = breed;
        }

        public void Activity()
        {
            Console.WriteLine("Пес виляє хвостом");
        }

        public void Heal()
        {
            Console.WriteLine("Собака лікується у ветеринара");
        }

        public void Bark()
        {
            Console.WriteLine("Собака гавкає");
        }
    }
}