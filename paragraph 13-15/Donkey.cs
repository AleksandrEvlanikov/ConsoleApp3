using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Donkey : AnimalPackAbstract
    {
        private static int hourseCount = 0;
        public Donkey(string nameAnimals, int age, string commandExecute) : base(nameAnimals, age, commandExecute)
        {
            hourseCount++;
            this.NameAnimals = nameAnimals;
        }

        public override string? ToString()
        {
            return $"Осел по кличке - {NameAnimals}, {Age} - года, выполняет команду: {CommandExecute}";
        }
    }
}
