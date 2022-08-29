using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    public class IsQualified
    {
        public static bool IsClientQualified(int debt, IClient client)
        {
            if (debt == 0 && client.BorrowedBooks.Count < 3)
                return true;
            else
                return false;
        }
    }
}