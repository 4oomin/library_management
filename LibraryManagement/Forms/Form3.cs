public class Form3 : Form
{
    private BookService bookService;
    private List<book> bookList;

    public Form3()
    {
        InitializeComponent();
        bookService = new BookService(new BookRepository());
        bookList = bookService.EntityAll();
        BookCleanUp();
        BookLoad();
    }

    private void BookLoad()
    {
        BookDataView.Rows.Clear();
        foreach(Book b in bookList)
            BookDataView.Rows.Add(b.name, b.email, b.password);
    }

    private void BookCleanUp()
    {
        BookTitleTxt = "";
        BookIsbnTxt = "";
    }

    private void BookRegisterBtn_Click(object sender, EventArgs e)
    {
        Book book = new book();
        book.title = BookTitleTxt.Text();
        book.isbn = BookIsbnTxt.Text();

        
        if(!bookService.CheckInputForm(book))
        {
            BookResultLbl.Text = "[ fail ] check input value";
            return;
        }

        if(!bookService.CheckDuplication(book))
        {
            BookResultLbl.Text = "[ fail ] already exists";
            return;
        }

        if(!bookService.Register(book))
        {
            BookResultLbl.Text = "[ fail ] system error";
            return;
        }

        BookResultLbl.Text = "[ success ] complete to register";
        BookCleanUp();
        BookLoad();
    }

    private void BookRemoveBtn_Click(object sender, EventArgs e)
    {
        Book book = new book();
        book.title = BookTitleTxt.Text();
        book.isbn = BookIsbnTxt.Text();
        
        if(!bookService.CheckInputForm(book))
        {
            BookResultLbl.Text = "[ fail ] check input value";
            return;
        }

        if(bookService.CheckDuplication(book))
        {
            BookResultLbl.Text = "[ fail ] not to exist";
            return;
        }

        if(!bookService.Delete(book))
        {
            BookResultLbl.Text = "[ fail ] system error";
            return;
        }

        BookResultLbl.Text = "[ success ] complete to remove";
        BookCleanUp();
        BookLoad();
    }

}