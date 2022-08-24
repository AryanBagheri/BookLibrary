using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    class Program
    {
        //enroll


        public static void Main(string[] args)
        {
            BookLibrary library = new BookLibrary();
            List<IBook> books = new List<IBook>();
            List<IClient> clients = new List<IClient>();
            string name;
            string clientsName;
            int clnt;
            int pickedbook;
            int pickedbook2;
            int debt;

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
                        library.EnrollClient(ref clients);
                        break;

                    case "2":
                        Console.Write("pls enter the name of the book you want to borrow. ");
                        name = Console.ReadLine();
                        Console.Write("pls enter your name: ");
                        clientsName = Console.ReadLine();
                        clnt = library.SearchClients(clientsName, clients);
                        if (clnt == -1)
                        {
                            System.Console.WriteLine("sorry you are not registered. ");
                            break;
                        }
                        pickedbook = library.SearchBooks(name, books);
                        debt = library.DebtCallculator(clnt, clients);
                        library.BorrowBook(pickedbook, debt, clnt, ref books, ref clients);
                        break;

                    case "3":
                        Console.Write("pls enter the name of the book you want to borrow. ");
                        name = Console.ReadLine();
                        Console.Write("pls enter your lastname: ");
                        clientsName = Console.ReadLine();
                        clnt = library.SearchClients(clientsName, clients);
                        pickedbook = library.SearchBooks(name, clients[clnt].BorrowedBooks);
                        pickedbook2 = library.SearchBooks(name, books);
                        library.ReturnBook(pickedbook, pickedbook2, clnt, ref books, ref clients);
                        break;

                    case "4":
                        Console.Write("pls enter the name you want to add: ");
                        name = Console.ReadLine();
                        pickedbook = library.SearchBooks(name, books);
                        library.AddBook(pickedbook, ref books);
                        break;

                    case "5":
                        Console.Write("pls enter your lastname: ");
                        clientsName = Console.ReadLine();
                        clnt = library.SearchClients(clientsName, clients);
                        if (clnt == -1)
                        {
                            System.Console.WriteLine("sorry you are not registered. ");
                            break;
                        }
                        if (clients[clnt].BorrowedBooks.Count>0)
                        {
                         for (var i = 0; i < clients.Count; i++)
                        {
                            Console.WriteLine(clients[clnt].BorrowedBooks[i].fullName);
                        }
                        }
                        debt = library.DebtCallculator(clnt, clients);
                        Console.Write("your debt is: ");
                        Console.WriteLine(debt);
                        break;

                    case "6":
                        Console.Write("pls enter your lastname: ");
                        clientsName = Console.ReadLine();
                        clnt = library.SearchClients(clientsName, clients);
                        if (clnt == -1)
                        {
                            System.Console.WriteLine("sorry you are not registered. ");
                            break;
                        }
                        debt = library.DebtCallculator(clnt, clients);
                        library.DebtCollector(debt);
                        break;

                    case "7":
                        for (var i = 0; i < books.Count; i++)
                        {
                            Console.WriteLine(books[i].fullName);
                        }
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