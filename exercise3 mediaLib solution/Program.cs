using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {// album instances
          var album1 = new Album("yellow Submarine","The Beatles" );
          var album2 = new Album("The Wall","Pink Floyd");
          var album3 = new Album("Omwoyo","Sheebah Karungi");
          
          var book1 = new Book("C# programming","Gertrude");
          var book2 = new Book("The Bakenye","Henry Wabwire");
          var book3 = new Book("Full Woman","Florence");

          var movie1 = new Movie("Lawrence of Arabia","David Lean");
          var movie2 = new Movie("God loves Uganda","Roger Ross Williams");
          var movie3 = new Movie("Queen of Katwe","Mira Nair");
          
          Console.WriteLine(album1.GetDisplayText());
          Console.WriteLine(album2.GetDisplayText());
          Console.WriteLine(album3.GetDisplayText());
          Console.WriteLine("");

          Console.WriteLine(book1.GetDisplayText());
          Console.WriteLine(book2.GetDisplayText());
          Console.WriteLine(book3.GetDisplayText()); 
          Console.WriteLine(""); 

          Console.WriteLine(movie1.GetDisplayText()); 
          Console.WriteLine(movie2.GetDisplayText()); 
          Console.WriteLine(movie3.GetDisplayText()); 
          Console.WriteLine("");

          //lets loan out the first item of each media type:
          album1.Loan("Joe Smith"); //loaned to Joe Smith
          book1.Loan("Mary Gertrude LN");
          movie1.Loan("Hans Petter LN");

          //added in challenge 3:
          album2.Loan(); //to test when loanee name is unknown

        // writeout the media information to confirm its loaned out
          Console.WriteLine(album1.GetDisplayText());
          Console.WriteLine(album2.GetDisplayText());
          Console.WriteLine(book1.GetDisplayText());
          Console.WriteLine(movie1.GetDisplayText());
          Console.WriteLine("");
          //Return the loaned item
          album1.Return();
          album2.Return();
          book1.Return();
          movie1.Return();

          //Write out information to confirm item returned
          Console.WriteLine(album1.GetDisplayText());
          Console.WriteLine(album2.GetDisplayText());
          Console.WriteLine(book1.GetDisplayText());
          Console.WriteLine(movie1.GetDisplayText());
        }

        
    }
}