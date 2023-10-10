using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Horse : AnimalPackAbstract
    {
        private static int hourseCount = 0;
        public Horse(string nameAnimals, int age, string commandExecute) : base(nameAnimals, age, commandExecute)
        {
            hourseCount++;
            this.NameAnimals = nameAnimals;
        }

        public override string? ToString()
        {
            return $"Лошадь по кличке - {NameAnimals}, {Age} - года, выполняет команду: {CommandExecute}";
        }
    }
}
