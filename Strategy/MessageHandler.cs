using Design_Patterns_Assignment.Strategy.Messages;
using Design_Patterns_Assignment.Strategy.Sender;
using System;

namespace Design_Patterns_Assignment
{
    internal class MessageHandler
    {

        internal static void SendMessage (string message)
        {
            // Draw Menu
            Console.WriteLine("---------------------");
            Console.WriteLine("  Select type of message  ");
            Console.WriteLine("---------------------");
            Console.WriteLine("S: Send as SMS");
            Console.WriteLine("E: Send as Email");
            Console.WriteLine("F: Send as FacebookMessage");
            Console.WriteLine("X: Exit Program");


            var sender = new Sender();

            //default messagetype is SMS
            sender.Message = new Sms();

            while (true)
            {
                // Get User Input
                char userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 's' or 'S':
                        Console.WriteLine("You selected SMS");
                        sender.Message = new Sms();
                        sender.Send(message);
                        RestartMenu(message);
                        break;
                    case 'e' or 'E':
                        Console.WriteLine("You selected Email");
                        sender.Message = new Emajl();
                        sender.Send(message);
                        RestartMenu(message);
                        break;
                    case 'f' or 'F':
                        Console.WriteLine("You selected FacebookMessage");
                        sender.Message = new FacebookMessage();
                        sender.Send(message);
                        RestartMenu(message);
                        break;
                    case 'x' or 'X':
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("That is not a valid choice");
                        break;
                }   
            }
        }

        public static void RestartMenu(string message)
        {
            Console.ReadKey();
            Console.Clear();
            SendMessage(message);
        }
    }
}