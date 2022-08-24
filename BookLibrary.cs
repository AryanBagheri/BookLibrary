using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    public class BookLibrary
    {
        public void EnrollClient(ref List<IClient> clients)
        {
            Console.Write($"pls Enter your name: ");
            string name = Console.ReadLine();
            Console.Write($"pls enter your familyname: ");
            string lastname = Console.ReadLine();
            Console.WriteLine($"pls enter your subscribtion type: \n1. Normal");
            int subscribtionType = int.Parse(Console.ReadLine());
            if (subscribtionType == 1)
            {
                IClient newPerson = new NormalClient(name, lastname);
                clients.Add(newPerson);
            }
        }
        public IBook AddBookData()
        {
            Console.Write("pls enter the name of the book: ");
            string name = Console.ReadLine();
            Console.Write("pls enter the barcode of the book: ");
            int barcode = int.Parse(Console.ReadLine());
            Console.Write("what genre is you your book? ");
            string genre = Console.ReadLine();
            if (genre == "SciFi")
            {
                IBook newItem = new SciFiBook(name, genre, barcode);
                return newItem;
            }
            else
            {
                IBook newItem = new NovelBook(name, genre, barcode);
                return newItem;
            }
        }

        //adds new book in the book library
        public void AddBook(int x, ref List<IBook> books)
        {
            if (x == -1)
            {
                IBook newItem = AddBookData();
                books.Add(newItem);
            }
            else
            {
                Console.WriteLine("the book you wanted to add is already exists.");
            }
        }

        //checkes if the book you want to add or borrow is available or not
        public int SearchBooks(string name, List<IBook> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].fullName == name)
                {
                    return i;
                }
            }
            return -1;
        }
        public void BorrowBook(int pickedbk, int dbt,int clnt, ref List<IBook> books, ref List<IClient> client)
        {
            if (pickedbk == -1)
            {
                Console.WriteLine($"sorry we dont have that book. ");
            }
            else
            {
                if (dbt == 0 && client[clnt].BorrowedBooks.Count < 3)
                {
                    if (books[pickedbk].IsAvailable)
                    {
                        books[pickedbk].dateBorrowed = DateTime.Now;
                        client[clnt].BorrowedBooks.Add(books[pickedbk]);
                        books[pickedbk].IsAvailable = false;
                    }
                    else
                    {
                        Console.WriteLine($"sorry somebody has already borrowed that book. ");

                    }
                }
                else
                {
                    Console.WriteLine
                    ($"sorry you cannot borrow this book, pls check if you have debt or maximum number of borrowed books. ");
                }
            }
        }

        public void ReturnBook(int pickedbk, int pickedbk2,int clnt, ref List<IBook> books, ref List<IClient> client)
        {
            client[clnt].BorrowedBooks.RemoveAt(pickedbk);
            books[pickedbk2].IsAvailable = true;
            Console.WriteLine($"ok. ");
        }

        public int SearchClients(string lastName, List<IClient> clients)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].lastName == lastName)
                {
                    return i;
                }
            }
            return -1;
        }

        //calculates debt
        public int DebtCallculator(int clnt, List<IClient> client)
        {
            DateTime dt = DateTime.Now;
            var totalDays = 0;
            if(client[clnt].BorrowedBooks.Count > 0)
            {
            for (var i = 0; i < 3; i++)
            {
                var days = dt - client[clnt].BorrowedBooks[i].dateBorrowed;
                if (days.Days > 14)
                {
                    totalDays += (days.Days - 14);
                }
            }
            }
            return totalDays * 100;
        }
        //gets rid of debt
        public void DebtCollector(int debt)
        {
            Console.WriteLine($"you have {debt}$ to pay.");
            Console.ReadKey();
            Console.WriteLine("tnx");
        }
    }
}