using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Cat : PetAbstract
    {
        private static int catCount = 0;
        public Cat(string nameAnimals, int age, string commandExecute) : base(nameAnimals, age, commandExecute)
        {
            catCount++;
            this.NameAnimals= nameAnimals;

        }

        public override string? ToString()
        {
            return $"Котик по кличке - {NameAnimals}, {Age} - года, выполняет команду: {CommandExecute}";
        }
    }
}
