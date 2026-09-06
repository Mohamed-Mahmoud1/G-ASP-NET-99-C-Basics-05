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
        }
    }
}
