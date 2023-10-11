namespace Hemmaövning_Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var book1 = new Book("The Lord of the Rings", "J.R.R Tolkien", "1954", "Fantasy");

            var movie1 = new Movie("The Departed", "Martin Scorcese", "2006", "Crime Drama");

            var album1 = new MusicAlbum("My Beautiful Dark Twisted Fantasy", "Kanye West", "2010", "Hip Hop/Rap");

            MediaLibrary.AddMedia(book1);
            MediaLibrary.AddMedia(movie1);
            MediaLibrary.AddMedia(album1);

            MediaLibrary.DisplayAllMedia();
        }
    }
}