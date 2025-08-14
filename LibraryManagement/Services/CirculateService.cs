using System.Text.RegularExpressions;
public class CirculateService : AService<Circulate>
{
    public CirculateService(IRepository<Circulate> repository)
        : base(repository)
    {

    }

    public override bool CheckDuplication(Circulate circulate)
    {
        foreach(Circulate c in entityList)
        {
            if((c.member_id == circulate.member_id) &&
               (c.book_id== circulate.book_id))
               {
                    return false;
               }
        }
        return true;
    }

    public override bool CheckInputForm(string email, string isbn)
    {   
        string pattern = @"^\d{3}-\d{2}-\d{6}-\d{1}-\d{1}$";
        if (string.IsNullOrWhiteSpace(email) && !email.Contains("@")) return false;
        if (string.IsNullOrWhiteSpace(isbn) && !Regex.IsMatch(isbn, pattern)) return false;
        return true;
    }

}