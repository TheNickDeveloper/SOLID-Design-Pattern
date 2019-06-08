using DemoLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IBorrowableDVD dvd = new DVD();
            IBorrowableDVD digitalMovie = new DigitalMovie();
            IBorrowableBook harryPotter = new Book();
            IBook libraryRefBook = new ReferenceBook();

            Console.ReadLine();
        }
    }
}
