using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class Observer
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");
            var email = "";
            while (string.IsNullOrEmpty(email))
            {
                email=Email.Check();
            }            
            Console.WriteLine(email);
            Console.WriteLine();
        }
    }
}
