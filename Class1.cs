using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    internal class Dog : Animal
    {
        public Dog(string name, int age, string typeofanimal, string birth, bool deffects, bool isTrained, string breed) :
        base(name, age, typeofanimal, birth, deffects, isTrained, breed)
        {
        }
    }
}


