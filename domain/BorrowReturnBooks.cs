using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    public class BorrowReturnBooks
    {
        public static void BorrowBook(int pickedbk, int clnt, ref List<IBook> books, ref List<IClient> client)
        {
            if (pickedbk == -1)
            {
                Console.WriteLine("sorry we dont have that book. ");
            }
            else
            {
                if (client[clnt].IsQualified)
                {
                    if (books[pickedbk].IsAvailable)
                    {
                        books[pickedbk].dateBorrowed = DateTime.Now;
                        books[pickedbk].IsAvailable = false;
                        books[pickedbk].NumberOfClientOnTheList = clnt;
                        client[clnt].BorrowedBooks.Add(books[pickedbk]);
                    }
                    else
                    {
                        Console.WriteLine("sorry somebody has already borrowed that book. ");

                    }
                }
                else
                {
                    Console.WriteLine
                    ("sorry you cannot borrow this book, pls check if you have debt or maximum number of borrowed books. ");
                }
            }
        }

        public static void ReturnBook(int pickedbkBooksList, int pickedbkClient, int clnt, ref List<IBook> books, ref List<IClient> client)
        {
            client[clnt].BorrowedBooks.RemoveAt(pickedbkClient);
            books[pickedbkBooksList].IsAvailable = true;
            books[pickedbkBooksList].NumberOfClientOnTheList = -1;
            Console.WriteLine("ok. ");
        }
    }
}