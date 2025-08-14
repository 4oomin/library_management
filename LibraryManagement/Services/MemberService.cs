public class MemberService : AService<Member>
{
    public MemberService(IRepository<Member> repository)
        : base(repository)
    {

    }

    public override bool CheckDuplication(Member member)
    {
        foreach(Member m in entityList)
        {
            if(m.email == member.email) return false;
        }
        return true;
    }

    public override bool CheckInputForm(Member member)
    {
        if (string.IsNullOrWhiteSpace(member.name)) return false;
        if (string.IsNullOrWhiteSpace(member.password)) return false;
        if (string.IsNullOrWhiteSpace(member.email) && !(member.email).Contains("@")) return false;
        return true;
    }

    public Member FindMemberByEmail(string email)
    {
        foreach(Member m in entityList)
        {
            if(m.email == email) return m;
        }
        return null;
    }

    public Member FindMemberById(int id)
    {
        foreach(Member m in entityList)
        {
            if(m.id == id) return m;
        }
        return null;
    }

}

