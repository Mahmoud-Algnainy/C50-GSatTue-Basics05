using Microsoft.VisualBasic;
using System.Drawing;

namespace C50_GSatTue_Basics05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //Add a private string password = "secret"; field to a Book class. Try to print it from Main
            //(outside the class). What happens, and why?
            //Book zahra = new Book();

            //Console.WriteLine(zahra.password);
            // cant print it,  compile error happens because the password field is private and cannot be accessed from outside the Book class.

            #endregion
            #region Question 02
            //Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why ?
            //Book zahra = new Book();
            //Console.WriteLine(zahra.copiesInStock);
            // it compiles because the copiesInStock field is internal and can be accessed inside the same project.

            #endregion
            #region Question 03
            //Add a public string Title; field to Book. Set it and print it from Main.
            //Book zahra = new Book();
            //zahra.Title = "Zahra SE01";
            //Console.WriteLine(zahra.Title);

            #endregion
            #region Question 04
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            //assign it Genre.Science, and print it.
            //Book zahra = new Book();
            //zahra.BookGenre = Genre.Science;
            //Console.WriteLine(zahra.BookGenre);

            #endregion
            #region Question 05
            //Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);
            #endregion
            #region Question 06
            //Given int genreNumber = 1;, cast it into a Genre value and print the result.
            //int genreNumber = 1;
            //Genre genre = (Genre)genreNumber;
            //Console.WriteLine(genre);

            #endregion
            #region Question 07
            //Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
            //Genre genre = Genre.Fiction;
            //Console.WriteLine(genre.ToString());

            #endregion
            #region Question 08
            //Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and print the result
            //string genreText = "Science";
            //Genre genre = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(genre);

            #endregion
            #region Question 09
            //Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to attempt the conversion.Print "Unknown genre" if it fails.
            string genreText = "xyz";
            if (Enum.TryParse(genreText, out Genre genre))
            {
                Console.WriteLine(genre);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion
        }
    }
}
