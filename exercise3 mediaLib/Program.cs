using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {// album instances
          var album = new Album("yellow Submarine","The Beatles" );
          var book = new Book("Full Woman","Florence");
          var movie = new Movie("Queen of Katwe","Mira Nair");
          
          Console.WriteLine("Album: " + Title + " by " + Artist);
          Console.WriteLine("Book: " + Title + " by" + Author);
          Console.WriteLine("Movie: " + Title + " by " + Director);
        }

        
    }
}