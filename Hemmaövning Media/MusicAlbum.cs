using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemmaövning_Media
{
    internal class MusicAlbum : Media
    {
        public string Artist { get; set; }
        public MusicAlbum(string title, string artist, string year, string genre)
        {
            Title = title;
            Artist = artist;
            Year = year;
            Genre = genre;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Album Title: {Title}    Artist: {Artist}    Year: {Year}    Genre: {Genre}");
            Console.WriteLine();
        }
    }
}
