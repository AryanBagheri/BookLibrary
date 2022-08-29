using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    public interface IBook
    {
        public string fullName { get; set; }
        public string genre { get; set; }
        public int barcode { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime dateBorrowed { get; set; }
        public int NumberOfClientOnTheList { get; set; }
    }
}