using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    public class AddBook
    {
        public static IBook AddBookData()
        {
            Console.Write("pls enter the name of the book: ");
            string name = "_";
            name = Console.ReadLine();
            Console.Write("pls enter the barcode of the book: ");
            int barcode = 0;
            barcode = int.Parse(Console.ReadLine());
            Console.Write("what genre is you your book? ");
            string genre = "_";
            genre = Console.ReadLine();
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
        public static void AddBookToList(int searchedbook, ref List<IBook> books)
        {
            if (searchedbook == -1)
            {
                IBook newItem = AddBookData();
                books.Add(newItem);
            }
            else
            {
                Console.WriteLine("the book you wanted to add is already exists.");
            }
        }
    }
}