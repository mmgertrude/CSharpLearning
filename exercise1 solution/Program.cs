using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
          var album = new Album("yellow Submarine","The Beatles" );
          var book = new Book("C# programming","Gertrude");
          var movie = new Movie("Lawrence of Arabia","David Lean");
          
          
          Console.WriteLine("Album: {0} by {1}", album.Title, album.Artist);
          Console.WriteLine("Book: {0} by {1}", book.Title, book.Author);
          Console.WriteLine("Movie: {0} by {1}", movie.Title, movie.Director);

          //4a) album.Title = ("Let It Be");
          


        }
    }
}