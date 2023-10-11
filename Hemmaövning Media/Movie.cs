using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemmaövning_Media
{
    internal class Movie : Media
    {
        public string Director {  get; set; }
        public Movie(string title, string director, string year, string genre)
        {
            Title = title;
            Director = director;
            Year = year;
            Genre = genre;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Movie Title: {Title}    Director: {Director}    Year: {Year}    Genre: {Genre}");
            Console.WriteLine();
        }
    }
}
