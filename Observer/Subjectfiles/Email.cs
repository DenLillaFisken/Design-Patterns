using Design_Patterns_Assignment.Observer.Observerfiles;
using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.Observer.Subjectfiles
{
    internal class Email : IEmail
    {
        public List<IObserver> Observers { get; set; }

        public Email()
        {
            Observers = new();
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Added observer");
            Observers.Add(observer);
        }
        public void UnRegisterObserver(IObserver observer)
        {
            Console.WriteLine("Removed observer");
            Observers.Remove(observer);
        }
        public void notifyObservers(string email)
        {
            foreach (var observer in Observers)
            {
                observer.UpdateEmail(email);
            }
        }
        public void Check()
        {            
            string email = "this is the email";
            //Send to all watchers
            notifyObservers(email);
        }
    }
}