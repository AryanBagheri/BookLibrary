using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    public class SciFiBook : IBook
    {
        public string fullName { get; set; }
        public string genre { get; set; }
        public int barcode { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime dateBorrowed { get; set; }
        public SciFiBook(string name, string genre, int barcode)
        {
            this.fullName = name;
            this.genre = genre;
            this.barcode = barcode;
            this.IsAvailable = true;
            this.dateBorrowed = new DateTime();
        }
    }
}