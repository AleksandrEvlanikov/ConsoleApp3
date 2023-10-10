using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Camel : AnimalPackAbstract
    {
        private static int camelCount = 0;
        public Camel(string nameAnimals, int age, string commandExecute) : base(nameAnimals, age, commandExecute)
        {
            camelCount++;
            this.NameAnimals = nameAnimals;
        }

        public override string? ToString()
        {
            return $"Верблюд по кличке - {NameAnimals}, {Age} - года, выполняет команду: {CommandExecute}";
        }
    }
}
