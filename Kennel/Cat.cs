using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel
{
    public class Cat : Animal
    {
        int numberOfLives = 9;

        public Cat()
        {

        }

        public Cat(string name)
        {
            Name = name;
        }
    }
}
