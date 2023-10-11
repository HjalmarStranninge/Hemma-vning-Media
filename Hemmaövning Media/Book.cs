using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemmaövning_Media
{
    internal class Book : Media
    {
        public string Author { get; set; }

        public Book(string title,  string author, string year, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}    Author: {Author}    Year: {Year}    Genre: {Genre}");
            Console.WriteLine();
        }
    }
}
