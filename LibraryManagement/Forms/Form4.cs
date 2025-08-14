public class Form4 : Form
{
    private CirculateService circulateService;
    private List<Circulate> circulateList;

    public Form4()
    {
        InitializeComponent();
        circulateService = new CirculateService(new CirculateRepository());
        circulateList = circulateService.EntityAll();
        CirculateCleanUp();
        CirculateLoad();
    }

    private void CirculateLoad()
    {
        MemberService memberService = new MemberService(new MemberRepository());
        BookService bookService = new BookService(new BookRepository());
        
        CirculateDataView.Rows.Clear();
        foreach(Circulate c in circulateList)
            Member m = MemberService.FindMemberById(c.memberId);
            Book b = BookService.FindMemberById(c.bookId);
            CirculateDataView.Rows.Add(m.name, b.title, c.startDate, c.endDate);
    }

    private void CirculateCleanUp()
    {
        CirculateEmailTxt = "";
        CirculateIsbnTxt = "";
    }

    private void CirculateLoanBtn_Click(object sender, EventArgs e)
    {
        MemberService memberService = new MemberService(new MemberRepository());
        BookService bookService = new BookService(new BookRepository());
        Circulate circulate = new Circulate();
        DateTime start = DateTime.Today;
        DateTime end = start.AddDays(10);

        if(!circulateService.CheckInputForm(CirculateEmailTxt.Text(),CirculateIsbn.Txt.Text()))
        {
            CirculateResultLbl.Text = "[ fail ] check input value";
            return;
        }

        Member member = memberService.FindMemberByEmail(CirculateEmailTxt.Text());
        Book book = bookService.FindBookByIsbn(CirculateIsbn.Txt.Text());

        if(member==null || book ==null)
        {
            CirculateResultLbl.Text = "[ fail ] not to exist";
            return;
        }
        
        circulate.memberId = member.id;
        circulate.bookId= book.id;
        circulate.startDate = start.ToString("yyyy/MM/dd");
        circulate.endDate = end.ToString("yyyy/MM/dd");
        
        if(circulateService.CheckDuplication(circulate))
        {
            CirculateResultLbl.Text = "[ fail ] already exists";
            return;
        }

        if(circulateService.Register(circulate))
        {
            BookResultLbl.Text = "[ fail ] system error";
            return;
        }

        CirculateResultLbl.Text = "[ success ] complete to loan";
        CirculateCleanUp();
        CirculateLoad();
    }

    private void CirculateReturnBtn_Click(object sender, EventArgs e)
    {
        MemberService memberService = new MemberService(new MemberRepository());
        BookService bookService = new BookService(new BookRepository());
        Circulate circulate = new Circulate();


        if(!circulateService.CheckInputForm(CirculateEmailTxt.Text(),CirculateIsbn.Txt.Text()))
        {
            CirculateResultLbl.Text = "[ fail ] check input value";
            return;
        }

        Member member = memberService.FindMemberByEmail(CirculateEmailTxt.Text());
        Book book = bookService.FindBookByIsbn(CirculateIsbn.Txt.Text());

        if(member==null || book ==null)
        {
            CirculateResultLbl.Text = "[ fail ] not to exist";
            return;
        }

        circulate.memberId = member.id;
        circulate.bookId= book.id;

        if(!circulateService.CheckDuplication(circulate))
        {
            CirculateResultLbl.Text = "[ fail ] not to exist";
            return;
        }

        if(circulateService.Delete(circulate))
        {
            CirculateResultLbl.Text = "[ fail ] system error";
            return;
        }

        CirculateResultLbl.Text = "[ success ] complete to return";
        CirculateCleanUp();
        CirculateLoad();
    }

}