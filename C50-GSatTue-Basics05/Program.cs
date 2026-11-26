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
            Book zahra = new Book();

            //Console.WriteLine(zahra.password);
            // cant print it,  compile error happens because the password field is private and cannot be accessed from outside the Book class.

            #endregion
        }
    }
}
