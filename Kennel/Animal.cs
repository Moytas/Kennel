using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel
{
    public class Animal
    {
        public string Name;
        public int Age;
        //public string Type;

        public enum AnimalType
        {
            Dog,
            Cat,
            Bird,
            Other
        };

        public AnimalType _AnimalType; 
    }
}
