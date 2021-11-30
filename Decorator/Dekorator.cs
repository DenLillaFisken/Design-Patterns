using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.Decorator.Text;
using Design_Patterns_Assignment.Decorator.Text.Decorators;
using System;

namespace Design_Patterns_Assignment
{
    internal class Dekorator
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Decorator Pattern
            Console.WriteLine("Decorator");

            // Draw Menu
            Console.WriteLine("Decorate text");
            Console.WriteLine("---------------------");
            Console.WriteLine("  Select text-styles   ");
            Console.WriteLine("---------------------");
            Console.WriteLine("A: Show finnished text");
            Console.WriteLine("B: Add Bold");
            Console.WriteLine("C: Add Deleted");
            Console.WriteLine("D: Add Emphasized");
            Console.WriteLine("E: Add Important");
            Console.WriteLine("F: Add Inserted");
            Console.WriteLine("G: Add Italic");
            Console.WriteLine("H: Add Marked");
            Console.WriteLine("I: Add Smaller");
            Console.WriteLine("J: Add SubScript");
            Console.WriteLine("K: Add SuperScript");
            Console.WriteLine("X: Quit Program");

            Console.WriteLine("Please enter the text.");
            string textInput = Console.ReadLine();

            var textdecor = FCT.createText();

            //Main Loop
            while (true)
            {
                // Get User Input
                Console.WriteLine("Add a text style: ");
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                        //string result = HTMLGenerator.TagProcessor(textdecor, textInput);
                        Console.WriteLine(textdecor.GetTextStyle());
                        //TÖM RESULTAT
                        break;

                    case 'b' or 'B':
                        Console.WriteLine("Adding bold text");
                        textdecor = new Bold(textdecor);
                        break;

                    case 'c' or 'C':
                        Console.WriteLine("Adding Deleted text");
                        textdecor = new Deleted(textdecor);
                        break;

                    case 'd' or 'D':
                        Console.WriteLine("Adding Emphasized text");
                        textdecor = new Emphasized(textdecor);
                        break;

                    case 'e' or 'E':
                        Console.WriteLine("Adding Important text");
                        textdecor = new Important(textdecor);
                        break;

                    case 'f' or 'F':
                        Console.WriteLine("Adding Inserted text");
                        textdecor = new Inserted(textdecor);
                        break;

                    case 'g' or 'G':
                        Console.WriteLine("Adding Italic text");
                        textdecor = new Italic(textdecor);
                        break;

                    case 'h' or 'H':
                        Console.WriteLine("Adding Marked text");
                        textdecor = new Marked(textdecor);
                        break;

                    case 'i' or 'I':
                        Console.WriteLine("Adding Smaller text");
                        textdecor = new Smaller(textdecor);
                        break;

                    case 'j' or 'J':
                        Console.WriteLine("Adding SubScript text");
                        textdecor = new Subscript(textdecor);
                        break;

                    case 'k' or 'K':
                        Console.WriteLine("Adding SuperScript text");
                        textdecor = new Superscript(textdecor);
                        break;

                    case 'x' or 'X':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }

    }
}