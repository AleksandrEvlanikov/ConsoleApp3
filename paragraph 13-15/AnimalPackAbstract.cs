using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class AnimalPackAbstract : Animals, PackAnimals
    {
        public AnimalPackAbstract(string nameAnimals, int age, string commandExecute) : base(nameAnimals, age, commandExecute)
        {

        }

        public void CarryLoad()
        {
            Console.WriteLine($"{NameAnimals} - Переносит груз");
        }
    }
}
