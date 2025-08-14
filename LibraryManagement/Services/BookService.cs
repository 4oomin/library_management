using System.Text.RegularExpressions;
public class BookService : AService<Book>
{
    public BookService(IRepository<Book> repository)
        : base(repository)
    {

    }

    public override bool CheckDuplication(Book book)
    {
        foreach(Book b in entityList)
        {
            if(b.isbn == book.isbn) return false;
        }
        return true;
    }

    public override bool CheckInputForm(Book book)
    {   
        string pattern = @"^\d{3}-\d{2}-\d{6}-\d{1}-\d{1}$";
        if (string.IsNullOrWhiteSpace(book.isbn)) return false;
        return Regex.IsMatch(book.isbn, pattern);
    }

    public Book FindBookByIsbn(string isbn)
    {
        foreach(Book b in entityList)
        {
            if(b.isnb == isnb) return b;
        }
        return null;
    }

    public Book FindBookById(int id)
    {
        foreach(Book b in entityList)
        {
            if(b.id == id) return b;
        }
        return null;
    }

}