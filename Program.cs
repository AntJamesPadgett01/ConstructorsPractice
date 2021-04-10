using System;

namespace ConstructorsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books("Koko","Love Me", 389);
           // book1.author = "Koko";
           // book1.title = "Love Me";
            //book1.pages = 389;


            Books book2 = new Books("Tony","Two Things for Certain", 1954);
            // book2.author = "Tony";
            //book2.title = "Two Things For Certain";  Constructor replaceds all this work, cleans up code.
            //book2.pages = 1954;

            Books book3 = new Books();

            book2.pages = 3389;
            Console.WriteLine(book2.pages);

            
        }
    }
}
