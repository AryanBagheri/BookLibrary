using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    public class NormalClient : IClient
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public List<IBook> BorrowedBooks {get; set;}
        public int Debt { get; set; }
        public bool IsQualified { get; set; }

        public NormalClient(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
            this.BorrowedBooks = new List<IBook>();
        }
        
    }
}