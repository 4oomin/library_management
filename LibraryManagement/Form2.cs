using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            Member mem = new Member();
            MemberListData.Rows.Clear();
            foreach (Member m in mem.MemberList())
            {
                MemberListData.Rows.Add(m.ID, m.Name, m.Email, m.PassWord);
            }
        }

        private void MemberSignUpBtn_Click(object sender, EventArgs e)
        {
            // 1. member txt 정보 읽기
            Member mem = new Member();
            mem.Name = MemberNameTxt.Text;
            mem.Email = MemberEmailTxt.Text;
            mem.PassWord = MemberPwTxt.Text;
            // 2. db로 동일한 email 있는지 sql 날리기  : memberRead
            if (mem.MemberRead() != null)
            {   //3. 있으면 label에 [  fail  ] already exist
                MemberResultLbl.Text = "[  fail  ] already exist";
                return;
            }
            // 4. 없으면 label에 [ sucess ] complete
            MemberResultLbl.Text = "[sucess] complete";
            //    db에 member 정보 저장 sql 날리기     : memberInsert
            mem.MemberCreate();
            // 5. member btn 정보 비우기               : memberInputPanel_Set
            MemberNameTxt.Text = "";
            MemberEmailTxt.Text = "";
            MemberPwTxt.Text = "";
            // 6. 업데이트된 db 정보 다 data로 옮기기  : memberList
            // 7. db 다시 view에 뿌리기                : memberListData_Set
            MemberListData.Rows.Clear();
            foreach (Member m in mem.MemberList())
            {
                MemberListData.Rows.Add(m.ID, m.Name, m.Email, m.PassWord);
            }

        }

        private void MemberDeleteIdBtn_Click(object sender, EventArgs e)
        {
            // 1. member txt 정보 읽기
            Member mem = new Member();
            mem.Name = MemberNameTxt.Text;
            mem.Email = MemberEmailTxt.Text;
            mem.PassWord = MemberPwTxt.Text;
            // 2. db로 동일한 email 있는지 sql 날리기  : memberRead
            if (mem.MemberRead() == null)
            {   // 3. 없으면 label에 [  fail  ] not exist
                MemberResultLbl.Text = "[  fail  ] not exist";
                return;
            }
            // 4. 없으면 label에 [ sucess ] complete
            MemberResultLbl.Text = "[sucess] complete";
            //    db에 member 정보 삭제 sql 날리기     : memberDelete
            mem.MemberDelete();
            // 5. member btn 정보 비우기               : memberInputPanel_Set
            MemberNameTxt.Text = "";
            MemberEmailTxt.Text = "";
            MemberPwTxt.Text = "";
            // 6. 업데이트된 db 정보 다 data로 옮기기  : memberList
            // 7. db 다시 view에 뿌리기                : memberListData_Set
            MemberListData.Rows.Clear();
            foreach (Member m in mem.MemberList())
            {
                MemberListData.Rows.Add(m.ID, m.Name, m.Email, m.PassWord);
            }
        }
    }

}
