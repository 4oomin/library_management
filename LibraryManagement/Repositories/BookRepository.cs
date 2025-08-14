public class BookRepository : IRepository<Book>
{
    public const string path = @"_put your own path;";
    private SQLiteConnection conn;

    public BookRepository()
    {
        conn = new SQLiteConnection(path);
    }
    public int Create(Book book)
    {
        string sql = "INSERT INTO books (title, isbn) " +
                     "VALUES (@title, @isbn)";
        
        SQLiteCommand command = new SQLiteCommand(sql,conn);
        command.Parameters.AddWithValue("@title", book.title);
        command.Parameters.AddWithValue("@isbn", book.isbn);

        conn.Open();
        int result = command.ExecuteNonQuery();
        conn.Close();

        return result;
    }

    public int Delete(Book book)
    {
        string sql = "DELETE FROM books " +
                     "WHERE title = @title AND isbn = @isbn";
        
        SQLiteCommand command = new SQLiteCommand(sql,conn);
        command.Parameters.AddWithValue("@title", book.title);
        command.Parameters.AddWithValue("@isbn", book.isbn);

        conn.Open();
        int result = command.ExecuteNonQuery();
        conn.Close();

        return result;
    }
    
    public Book Read(int id)
    {
        string sql = "SELECT * FROM books" +
                     "WHERE id = @id";
        
        SQLiteCommand command = new SQLiteCommand(sql,conn);
        command.Parameters.AddWithValue("@id", id);

        conn.Open();
        SQLiteDataReader reader = command.ExecuteReader();
        Book book = null;
        if(reader.Read())
        {
            book = new Book();
            book.id = Convert.ToInt32(reader["id"]);
            book.title = reader["title"].ToString();
            book.isbn = reader["isbn"].ToString();
        }
        reader.Close();
        conn.Close();

        return book;
    }

    public List<Book> SelectAll()
    {
        string sql = "SELECT * FROM books";
        
        SQLiteCommand command = new SQLiteCommand(sql,conn);

        conn.Open();
        SQLiteDataReader reader = command.ExecuteReader();
        List<Book> bookList = new List<Book>();
        while (reader.Read())
        {
            Book book = new book();
            book.id = Convert.ToInt32(reader["id"]);
            book.name = reader["title"].ToString();
            book.email = reader["isbn"].ToString();
            bookList.Add(book);
        }
        reader.Close();
        conn.Close();

        return bookList;
    }
}
