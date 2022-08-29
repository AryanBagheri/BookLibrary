using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    public class Debt
    {
         public static int DebtCallculator(int clnt, List<IClient> client)
        {
            DateTime dt = DateTime.Now;
            var totalMinutes = 0;
            if (client[clnt].BorrowedBooks.Count > 0)
            {
                for (var i = 0; i < client[clnt].BorrowedBooks.Count; i++)
                {
                    var minutes = dt.Minute - client[clnt].BorrowedBooks[i].dateBorrowed.Minute;
                    if (minutes > 2)
                    {
                        totalMinutes += (minutes - 2);
                    }
                }
            }
            return totalMinutes * 10;
        }
        public static void DebtCollector(int debt)
        {
            Console.WriteLine($"you have {debt}$ to pay.");
            Console.ReadKey();
            Console.WriteLine("tnx");
        }
    }
}