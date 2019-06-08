using DemoLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = InstanceSetter.SetPersonInstance();
            owner.FirstName = "Tim";
            owner.LastName = "Corey";
            owner.EmailAddress = "tim@iamtimcorey.com";
            owner.PhoneNumber = "555-1212";

            IChore chore = InstanceSetter.SetChoreInstance(
                InstanceSetter.SetPhoneTextInstance(), InstanceSetter.SetLoggerInstance());
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
