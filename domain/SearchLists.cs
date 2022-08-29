using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    public class SearchLists
    {
        public static int Search(List<IClient> clients)
        {
            Console.Write("pls enter your lastname: ");
            string lastName = " ";
            lastName = Console.ReadLine();
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].lastName == lastName)
                {
                    return i;
                }
            }
            return -1;
        }
         public static int Search(List<IBook> books)
        {
            Console.Write("pls enter the name of the book you want: ");
            string name = " ";
            name = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].fullName == name)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}