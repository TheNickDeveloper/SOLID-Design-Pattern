using System;

namespace DemoLibrary
{
    public class PhoneText : IMessager
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"{person} sent a phone text with contents of: {message}.");
        }
    }
}
