using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Hamster : PetAbstract
    {
        private static int hamsterCount = 0;
        public Hamster(string nameAnimals, int age, string commandExecute) : base(nameAnimals, age, commandExecute)
        {
            hamsterCount++;
            this.NameAnimals = nameAnimals;
        }

        public override string? ToString()
        {
            return $"Хомяк по кличке - {NameAnimals}, {Age} - года, выполняет команду: {CommandExecute}";
        }
    }
}
