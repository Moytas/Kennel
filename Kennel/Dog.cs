using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel
{
    public class Dog : Animal
    {
       
        bool isHelp = false;

        public Dog()
        {
            _AnimalType = AnimalType.Dog;
            Name = "Unknown";
        }

        public Dog(string name)
        {
            Name = name;
        }

    }
}
