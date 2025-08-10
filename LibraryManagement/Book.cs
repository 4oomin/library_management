using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        public int ID;
        public string Title;
        public string Isbn;
        
        public Book()
        {
            this.ID = 0;
            this.Title = "";
            this.Isbn = "";
        }

        public const string DBpath = @"Data Source=C:\Sqlite3\DataBase\LibManageDB.sqlite;Version=3;";
        public SQLiteConnection conn = new SQLiteConnection(DBpath);

        public bool BookCreate()
        {
            int result;
            SQLiteCommand command;

            string sql = "INSERT INTO books (title, isbn) VALUES (@Title,@Isbn)";
            command = new SQLiteCommand(sql, conn);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Isbn", Isbn);

            conn.Open();
            result = command.ExecuteNonQuery();
            conn.Close();

            return true;
        }

        public Book BookRead()
        {
            Book book = null;

            string sql = "SELECT * FROM books WHERE isbn = @Isbn";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.Parameters.AddWithValue("@Isbn", Isbn);

            conn.Open();
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                book = new Book();
                book.ID = Convert.ToInt32(reader["id"]);
                book.Title = reader["title"].ToString();
                book.Isbn = reader["isbn"].ToString();
               
            }
            reader.Close();
            conn.Close();

            return book;
        }

        public bool BookDelete()
        {
            int result;
            SQLiteCommand command;

            string sql = "DELETE FROM books WHERE isbn = @Isbn";
            command = new SQLiteCommand(sql, conn);
            command.Parameters.AddWithValue("@Isbn", Isbn);

            conn.Open();
            result = command.ExecuteNonQuery();
            conn.Close();

            return true;
        }

        public List<Book> BookList()
        {
            List<Book> bookList = new List<Book>();

            string sql = "SELECT id, title, isbn FROM books";
            SQLiteCommand command = new SQLiteCommand(sql, conn);

            conn.Open();
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Book book = new Book();
                book.ID = Convert.ToInt32(reader["id"]);
                book.Title = reader["title"].ToString();
                book.Isbn = reader["isbn"].ToString();

                bookList.Add(book);
            }

            reader.Close();
            conn.Close();

            return bookList;
        }
    }
}
