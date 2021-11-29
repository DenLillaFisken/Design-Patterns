using System;

namespace Design_Patterns_Assignment
{
    internal class Strategy
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the strategy Pattern
            Console.WriteLine("Strategy");
            var message = "This is the message";
            MessageHandler.SendEmail(message);
            MessageHandler.SendSMS(message);
            MessageHandler.SendFacebookMessage(message);

            // What i want to happen to happen is
            //
            // Change type of message to send to sms etc.
            // send message            
        }
    }
}