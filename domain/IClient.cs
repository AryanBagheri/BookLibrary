using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    public interface IClient
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public int Debt { get; set; }
        public List<IBook> BorrowedBooks {get; set;}
        public bool IsQualified { get; set; }
    }
}