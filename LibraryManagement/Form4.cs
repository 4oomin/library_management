using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            Circulate cir = new Circulate();
            CirculateListData.Rows.Clear();
            foreach (Circulate c in cir.CirculateList())
            {
                CirculateListData.Rows.Add(c.ID, c.Name, c.Title, c.StartDate, c.EndDate);
            }
        }

        private void CirculateBorrowBtn_Click(object sender, EventArgs e)
        {
            Circulate cir = new Circulate();
            Book b = new Book();
            Book book = new Book();
            Member m = new Member();
            Member member = new Member();

            m.Email = CirculateEmailTxt.Text;
            b.Isbn = CirculateIsbnTxt.Text;


            if ((book = b.BookRead()) == null)
            {
                CirculateResultLbl.Text = "[  fail  ] book doesn't exist";
                return;
            }
            if ((member = m.MemberRead()) == null)
            {
                CirculateResultLbl.Text = "[  fail  ] member doesn't exist";
                return;
            }
            CirculateResultLbl.Text = "[sucess] complete";

            DateTime start = DateTime.Today;
            DateTime end = start.AddDays(10);
            cir.Name = member.Name;
            cir.Title = book.Title;
            cir.StartDate = start.ToString("yyyy/MM/dd");
            cir.EndDate = end.ToString("yyyy/MM/dd");

            cir.CirculateCreate();

            CirculateEmailTxt.Text = "";
            CirculateIsbnTxt.Text = ""; 

            CirculateListData.Rows.Clear();
            foreach(Circulate c in cir.CirculateList())
            {
                CirculateListData.Rows.Add(c.ID, c.Name, c.Title,c.StartDate,c.EndDate);
            }

        }

        private void CirculateReturnBtn_Click(object sender, EventArgs e)
        {
            Circulate cir = new Circulate();
            Book b = new Book();
            Book book = new Book();
            Member m = new Member();
            Member member = new Member();
            m.Email = CirculateEmailTxt.Text;
            b.Isbn = CirculateIsbnTxt.Text;


            if ((book = b.BookRead()) == null)
            {
                CirculateResultLbl.Text = "[  fail  ] book doesn't exist";
                return;
            }
            if ((member = m.MemberRead()) == null)
            {
                CirculateResultLbl.Text = "[  fail  ] member doesn't exist";
                return;
            }
            cir.Name = member.Name;
            cir.Title = book.Title;
            
            if(cir.CirculateRead()==null)
            {
               CirculateResultLbl.Text = "[  fail  ] circulation doesn't exist";
               return;
            }
            
            CirculateResultLbl.Text = "[sucess] complete";
            cir.CirculateDelete();

            CirculateEmailTxt.Text = "";
            CirculateIsbnTxt.Text = "";

            CirculateListData.Rows.Clear();
            foreach (Circulate c in cir.CirculateList())
            {
                CirculateListData.Rows.Add(c.ID, c.Name, c.Title, c.StartDate, c.EndDate);
            }
        }
    }
}
