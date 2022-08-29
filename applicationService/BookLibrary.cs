using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    public class BookLibrary
    {
        List<IBook> books = new List<IBook>();
        List<IClient> clients = new List<IClient>();


        public void LibraryEnrollClient()
        {
            Enrollment.EnrollClient(ref clients);
        }


        public void LibraryBorrowBook()
        {
            int clnt = SearchLists.Search(clients);
            if (clnt > 0)
            {

                int srchdBook = SearchLists.Search(books);
                int debt = Debt.DebtCallculator(clnt, clients);
                clients[clnt].IsQualified = IsQualified.IsClientQualified(debt, clients[clnt]);
                BorrowReturnBooks.BorrowBook(srchdBook, clnt, ref books, ref clients);
            }
            else
                Console.WriteLine("sorry you have'nt registered yet. ");
        }


        public void LibraryReturnBook()
        {
            int clnt = SearchLists.Search(clients);
            if (clnt > 0)
            {
                int srchdBook = SearchLists.Search(books);
                int srchClientsbooks = SearchLists.Search(clients[clnt].BorrowedBooks);
                BorrowReturnBooks.ReturnBook(srchdBook, srchClientsbooks, clnt, ref books, ref clients);
            }
            else
                Console.WriteLine("sorry you have'nt registered yet. ");
        }


        public void LibraryAddBookToList()
        {
            int pickedbk = SearchLists.Search(books);
            AddBook.AddBookToList(pickedbk, ref books);
        }


        public void LibraryCalculateMyDebt()
        {
            int clnt = SearchLists.Search(clients);
            if (clnt > -1)
            {
                int debt = Debt.DebtCallculator(clnt, clients);
                Console.WriteLine($"your debt is {debt}$.");
            }
            else
                Console.WriteLine("sorry you have'nt registered yet. ");
        }


        public void LibraryCollectMyDebt()
        {
            int clnt = SearchLists.Search(clients);
            if (clnt > 0)
            {
                int debt = Debt.DebtCallculator(clnt, clients);
                Debt.DebtCollector(debt);
            }
            else
                Console.WriteLine("sorry you have'nt registered yet. ");
        }


        public void LibraryPrintBooks()
        {
            for (var i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i].fullName);
            }
        }
    }
}