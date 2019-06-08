using System;

namespace DemoLibrary
{
    public class Emailer : IMessager
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email to { person.EmailAddress }");
        }
    }
}
