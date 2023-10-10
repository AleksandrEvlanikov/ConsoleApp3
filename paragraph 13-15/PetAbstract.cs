using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class PetAbstract : Animals, Pets
    {
        public PetAbstract(string nameAnimals, int age, string commandExecute) : base(nameAnimals, age, commandExecute)
        {

        }


        public void Play()
        {
            Console.WriteLine($"{NameAnimals} играет");
        }
    }
}
