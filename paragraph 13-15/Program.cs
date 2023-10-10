namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Animals cat = new Cat("Пушистик", 2, "Прыгает");

            List<Animals> animalslist = new List<Animals>();


            bool exit = false;
            while (!exit)
            {
                //Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Создать животное.");
                Console.WriteLine("2. Информация о животных");
                Console.WriteLine("3. Выучить новую команду.");
                Console.WriteLine("4. Выход");

                Console.Write("Выберите опцию: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Вы выбрали создание животного");
                        Console.WriteLine("Выберите типо животного");
                        Console.WriteLine("1. Cat");
                        Console.WriteLine("2. Dog");
                        Console.WriteLine("3. Hamster");
                        Console.WriteLine("4. Horse");
                        Console.WriteLine("5. Donkey");
                        Console.WriteLine("6. Camel");
                        Console.Write("Введите номер выбранного типа: ");
                        string animalType = Console.ReadLine();

                        Console.Write("Введите имя животного: ");
                        string name = Console.ReadLine();
                        addNameAnimals nameModifier = new addNameAnimals();
                        name = nameModifier.add(name);

                        Console.Write("Введите возраст животного: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.Write("Введите команду для животного: ");
                        string comand = Console.ReadLine();

                        Animals animal = null;
                        


                        switch (animalType)
                        {
                            case "1":
                                animal = new Cat(name, age, comand);
                                break;
                            case "2":
                                animal = new Dog(name, age, comand);
                                break;
                            case "3":
                                animal = new Hamster(name, age, comand);
                                break;
                            case "4":
                                animal = new Horse(name, age, comand);
                                break;
                            case "5":
                                animal = new Donkey(name, age, comand);
                                break;
                            case "6":
                                animal = new Camel(name, age, comand);
                                break;
                        }
                        animalslist.Add(animal);
                        
                        
                        break;


                    case "2":
                        Console.WriteLine("Список животных");
                        
                        foreach (var animalResult in animalslist)
                        {
                            
                            Console.WriteLine(animalResult.ToString());
                        }
                        break;

                    case "3":
                        Console.WriteLine("Обучение новой команде животного.");
                        Console.WriteLine("Введите имя животного, который будет учить команду.");
                        string animalName = Console.ReadLine();
                        Animals selectAnimal = animalslist.Find(animal => animal.NameAnimals.Equals(animalName, StringComparison.OrdinalIgnoreCase));

                        if (selectAnimal != null)
                        {
                            Console.WriteLine($"Введите новую команду для {selectAnimal.NameAnimals} ");
                            string newCommand = Console.ReadLine();
                            selectAnimal.CommandExecute = newCommand;
                            Console.WriteLine($"Команда выучена {selectAnimal.NameAnimals}");

                        }
                        else
                        {
                            Console.WriteLine($"Животное с именим {animalName} не найдено.");
                        }
                        break;
                        
                    case "4":
                        exit = true;
                        Console.WriteLine("Работа завершина.");
                        break;
                }
                
                
            }


        }
    }
}