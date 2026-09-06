namespace project05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //1.Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?
            //Book book = new Book();
            //Console.WriteLine(book.password);// This line will cause a compilation error because (password) is private and cannot be accessed from outside the (Book) class.
            #endregion

            #region Question02
            //2.Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why?
            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock);// This line will work because (copiesInStock) is internal and can be accessed from the same project.
            #endregion

            #region Question03
            //3.Add a public string Title; field to Book. Set it and print it from Main.
            //Book book = new Book();
            //book.Title = "C# Basics";
            //Console.WriteLine(book.Title);// This line will work because (Title) is public and can be accessed from anywhere.
            #endregion

            #region Question04
            //4.Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it
            //Book book = new Book();
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);
            #endregion

            #region Question05
            //5.Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);

            #endregion

            #region Question06
            //6.Given int genreNumber = 1;, cast it into a Genre value and print the result.
            //int genreNumber = 1;
            //Genre gern = (Genre)genreNumber;
            //Console.WriteLine(gern);
            #endregion
        }
    }
}
