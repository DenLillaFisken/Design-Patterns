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

            // Create a timer and set a five second interval.
            aTimer = new Timer();
            aTimer.Interval = 5000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;

            Console.WriteLine("Press 'U' to unsubscribe, 'S' to Re-subscribe or 'X' to quit program");

            //Check user input to determin what to do
            string check = Console.ReadLine().ToLower();
            while (check != "x")
            {
                if (check == "u")
                {
                    //Unregister Observer
                    Email.UnRegisterObserver(EmailWatcher);
                }
                else if (check == "s")
                {
                    //Register Observer
                    Email.RegisterObserver(EmailWatcher);
                }
                else
                {
                    Console.WriteLine("That is not a choise");
                }
                check = Console.ReadLine().ToLower();
            }
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //Will run the subjectmethod that will update the console
            Email.Check();
        }
    }
}
