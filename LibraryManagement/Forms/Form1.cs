public class Form1 : Form
{
    private Form2 memberForm;
    private Form3 bookForm;
    private Form4 circulateForm;

    public Form1()
    {
        InitializeComponent();
    }

    public void MemberBtn_Click(object sender, EventArgs e)
    {
        if(memberForm == null)
        {
            memberForm  = new Form2();
            memberForm.Show();
        }
        else
        {
            memberForm.BringToFront();
        }
    }

    public void BookBtn_Click(object sender, EventArgs e)
    {
        if(bookForm == null)
        {
            bookForm  = new Form2();
            bookForm.Show();
        }
        else
        {
            bookForm.BringToFront();
        }
    }

    public void CirculateBtn_Click(object sender, EventArgs e)
    {
        if(circulateForm == null)
        {
            circulateForm  = new Form2();
            circulateForm.Show();
        }
        else
        {
            circulateForm.BringToFront();
        }
    }

}