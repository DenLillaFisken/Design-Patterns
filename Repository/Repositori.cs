using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Repository;
using System;

namespace Design_Patterns_Assignment
{
    internal class Repositori
    {
        public static void ShowMenu()
        {
            // Draw Menu
            Console.WriteLine("--------------------");
            Console.WriteLine("  Select an action  ");
            Console.WriteLine("--------------------");
            Console.WriteLine("A: Get data from db");
            Console.WriteLine("B: Get customer from db");
            Console.WriteLine("C: Get animal from db");
            Console.WriteLine("D: Save data to db");
            Console.WriteLine("E: Save customer to db");
            Console.WriteLine("F: Save animal to db");
            Console.WriteLine("X: Exit program");
        }

        internal static void Run()
        {
            // Refactor this code so that it uses the Repository Pattern
            Console.WriteLine("Repository");

            // Draw Menu
            ShowMenu();

            //initiera data repository
            var datarepository = new DataRepository();
            string data = "";
            string customer = "";
            string animal = "";

            while (true)
            {
                // Get User Input
                var userInput = Console.ReadKey(true).KeyChar;
                
                switch (userInput)
                {
                    case 'a' or 'A':
                        data = datarepository.GetData();
                        Console.WriteLine("hämtat objekt: " + data);
                        RestartMenu();
                        break;
                    case 'b' or 'B':
                        customer = datarepository.GetCustomer();
                        Console.WriteLine("hämtat objekt: " + customer);
                        RestartMenu();
                        break;
                    case 'c' or 'C':
                        animal = datarepository.GetAnimal();
                        Console.WriteLine("hämtat objekt: " + animal);
                        RestartMenu();
                        break;
                    case 'd' or 'D':
                        if (data != "")
                        {
                            datarepository.SaveData(data);
                            RestartMenu();
                        }
                        else
                            Console.WriteLine("There is nothing to save");
                        RestartMenu();
                        break;
                    case 'e' or 'E':
                        if (customer != "")
                        {
                            datarepository.SaveData(customer);
                            RestartMenu();
                        }
                        else
                            Console.WriteLine("There is nothing to save");
                        RestartMenu();
                        break;
                    case 'f' or 'F':
                        if (animal != "")
                        {
                            datarepository.SaveData(animal);
                            RestartMenu();
                        }
                        else
                            Console.WriteLine("There is nothing to save");
                        RestartMenu();
                        break;

                    case 'x' or 'X':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        RestartMenu();
                        break;
                }
            }
        }
        public static void RestartMenu()
        {
            Console.ReadKey();
            Console.Clear();
            ShowMenu();
        }
    }
}