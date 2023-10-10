using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Dog : PetAbstract
    {
        private static int dogCount = 0;
        public Dog(string nameAnimals, int age, string commandExecute) : base(nameAnimals, age, commandExecute)
        {
            dogCount++;
            this.NameAnimals = nameAnimals;
        }

        public override string? ToString()
        {
            return $"Собака по кличке - {NameAnimals}, {Age} - года, выполняет команду: {CommandExecute}";
        }
    }

}
