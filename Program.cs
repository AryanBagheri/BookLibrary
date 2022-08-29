using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    class Program
    {
        public static void Main(string[] args)
        {
            BookLibrary library = new BookLibrary();

            while (true)
            {
                Console.WriteLine("hello and welcome to dv library. pls enter your command: ");
                Console.WriteLine("1. I want to enroll ");
                Console.WriteLine("2. I want to borrow a book ");
                Console.WriteLine("3. I want to return a book ");
                Console.WriteLine("4. I want to give away a book ");
                Console.WriteLine("5. How much is my debt? ");
                Console.WriteLine("6. I want my debt collected ");
                Console.WriteLine("7. Print books. ");
                Console.WriteLine("8. Exit. ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        library.LibraryEnrollClient();
                        break;

                    case "2":
                        library.LibraryBorrowBook();
                        break;

                    case "3":
                        library.LibraryReturnBook();
                        break;

                    case "4":
                        library.LibraryAddBookToList();
                        break;

                    case "5":
                        library.LibraryCalculateMyDebt();
                        break;

                    case "6":
                        library.LibraryCollectMyDebt();
                        break;

                    case "7":
                        library.LibraryPrintBooks();
                        break;

                    case "8":
                        return;

                    default:
                        Console.WriteLine("try again.");
                        break;
                }
            }
        }
    }
}