public class Form2 : Form
{
    public MemberService memberService;
    public List<Member> memberList;

    public Form2()
    {
        InitializeComponent();
        memberService = new MemberService(new MemberRepository());
        memberList = memberService.EntityAll();
        MemberCleanUp();
        MemberLoad();
    }

    private void MemberLoad()
    {
        MemberDataView.Rows.Clear();
        foreach(Member m in memberList)
            MemberDataView.Rows.Add(m.name, m.email, m.password);
    }

    private void MemberCleanUp()
    {
        MemberNameTxt = "";
        MemberEmailTxt = "";
        MemberPasswordTxt = "";
    }

    private void MemberRegisterBtn_Click(object sender, EventArgs e)
    {
        Member member = new Member();
        member.name = MemberNameTxt.Text();
        member.email = MemberEmailTxt.Text();
        member.password = MemberPasswordTxt.Text();
        
        if(!memberService.CheckInputForm(member))
        {
            MemberResultLbl.Text = "[ fail ] check input value";
            return;
        }

        if(!memberService.CheckDuplication(member))
        {
            MemberResultLbl.Text = "[ fail ] already exists";
            return;
        }

        if(!memberService.Register(member))
        {
            MemberResultLbl.Text = "[ fail ] system error";
            return;
        }

        MemberResultLbl.Text = "[ success ] complete to register";
        MemberCleanUp();
        MemberLoad();
    }

    private void MemberRemoveBtn_Click(object sender, EventArgs e)
    {
        Member member = new Member();
        member.name = MemberNameTxt.Text();
        member.email = MemberEmailTxt.Text();
        member.password = MemberPasswordTxt.Text();
        
        if(!memberService.CheckInputForm(member))
        {
            MemberResultLbl.Text = "[ fail ] check input value";
            return;
        }

        if(memberService.CheckDuplication(member))
        {
            MemberResultLbl.Text = "[ fail ] not to exist";
            return;
        }

        if(!memberService.Delete(member))
        {
            MemberResultLbl.Text = "[ fail ] system error";
            return;
        }

        MemberResultLbl.Text = "[ success ] complete to remove";
        MemberCleanUp();
        MemberLoad();
    }

}