using Design_Patterns_Assignment.Observer;
using Design_Patterns_Assignment.Observer.Observerfiles;
using Design_Patterns_Assignment.Observer.Subjectfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Design_Patterns_Assignment
{
    class ObserverClass
    {
        public static Email Email { get; set; }
        private static Timer aTimer;

        public static void Run()
        {
            //Register new email
            Email = new Email();
            //register new watcher
            EmailWatcher EmailWatcher = new EmailWatcher();

            // Add Observer
            Email.RegisterObserver(EmailWatcher);

            // Create a timer and set a two second interval.
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 5000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            //Will run the subjectmethod
            Email.Check();
        }
        //internal static void Runn()
        //{
            //// Draw Menu
            //Console.WriteLine("----------------------");
            //Console.WriteLine("   Select an action   ");
            //Console.WriteLine("----------------------");
            //Console.WriteLine("U: Update Email");
            //Console.WriteLine("S: Subscribe/Unsubscribe");
            //Console.WriteLine("E: Exit Program");

            ////Main Game Loop
            //while (true)
            //{
            //    // Get User Input
            //    var userInput = Console.ReadKey(true).KeyChar;

            //    switch (userInput)
            //    {
            //        case 'u' or 'U':
            //            subject.notifyObservers();
            //            break;

            //        case 's' or 'S':
            //            if (subject.Observers.Contains(EmailWatcher))
            //            {
            //                subject.UnRegisterObserver(EmailWatcher);
            //            }
            //            else
            //            {
            //                subject.RegisterObserver(EmailWatcher);
            //            }
            //            break;

            //        case 'e' or 'E':
            //            Environment.Exit(0);
            //            break;

            //        default:
            //            Console.Write("That is not a valid choice");
            //            break;
            //    }
            //}
        //}
    }
}
