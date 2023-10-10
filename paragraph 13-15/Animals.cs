using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Animals
    {
        private string nameAnimals;
        private int age;
        private string commandExecute;

        public Animals(string nameAnimals, int age, string commandExecute)
        {
            this.nameAnimals = nameAnimals;
            this.age = age;
            this.commandExecute = commandExecute;
        }

        public string NameAnimals
        {
            get { return nameAnimals; }
            set { nameAnimals = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string CommandExecute
        {
            get { return commandExecute; }
            set { commandExecute = value; }
        }



        public void executeCommand()
        {
            Console.WriteLine($"{nameAnimals} выполняет команду: {commandExecute}");
        }

        public override string? ToString()
        {
            return $"Имя - {NameAnimals}, {Age} - года, команда: {CommandExecute}";
        }
    }
}
