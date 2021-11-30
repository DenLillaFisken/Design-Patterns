using Design_Patterns_Assignment.Observer.Subjectfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.Observerfiles
{
    class EmailWatcher : IEmailWatcher
    {
        Email Email = new Email();
        //public void UpdateEmail(string notification)
        //{
        //    var email = "";
        //    while (string.IsNullOrEmpty(email))
        //    {
        //        email = Email.Check();
        //    }
        //    Console.WriteLine(email);
        //}
        public void UpdateEmail(string notification)
        {
            Console.WriteLine(notification);
        }
    }
}
