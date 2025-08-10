using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Book book = new Book();
            BookListData.Rows.Clear();
            foreach (Book b in book.BookList())
            {
                BookListData.Rows.Add(b.ID, b.Title, b.Isbn);
            }
        }

        private void BookRegisterBtn_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = BookTitleTxt.Text;
            book.Isbn = BookIsbnTxt.Text;


            if (book.BookRead() != null)
            {
                BookResultLbl.Text = "[  fail  ] already exist";
                return;
            }

            BookResultLbl.Text = "[sucess] complete";

            book.BookCreate();

            BookTitleTxt.Text = "";
            BookIsbnTxt.Text = "";

            BookListData.Rows.Clear();
            foreach (Book b in book.BookList())
            {
                BookListData.Rows.Add(b.ID, b.Title, b.Isbn);
            }
        }

        private void BookRemoveBtn_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = BookTitleTxt.Text;
            book.Isbn = BookIsbnTxt.Text;


            if (book.BookRead() == null)
            {
                BookResultLbl.Text = "[  fail  ] not exist";
                return;
            }

            BookResultLbl.Text = "[sucess] complete";

            book.BookDelete();

            BookTitleTxt.Text = "";
            BookIsbnTxt.Text = "";

            BookListData.Rows.Clear();
            foreach (Book b in book.BookList())
            {
                BookListData.Rows.Add(b.ID, b.Title, b.Isbn);
            }
        }
    }
}
