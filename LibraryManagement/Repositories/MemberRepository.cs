public class MemberRepository : IRepository<Member>
{
    public const string path = @"_put your own path_;";
    private SQLiteConnection conn;

    public MemberRepository()
    {
        conn = new SQLiteConnection(path);
    }
    public int Create(Member member)
    {
        string sql = "INSERT INTO members (name, email, password) " +
                     "VALUES (@name, @email, @password)";
        
        SQLiteCommand command = new SQLiteCommand(sql,conn);
        command.Parameters.AddWithValue("@name", member.name);
        command.Parameters.AddWithValue("@email", member.email);
        command.Parameters.AddWithValue("@password", member.password);

        conn.Open();
        int result = command.ExecuteNonQuery();
        conn.Close();

        return result;
    }

    public int Delete(Member member)
    {
        string sql = "DELETE FROM members " +
                     "WHERE name = @name AND email = @email AND password = @password";
        
        SQLiteCommand command = new SQLiteCommand(sql,conn);
        command.Parameters.AddWithValue("@name", member.name);
        command.Parameters.AddWithValue("@email", member.email);
        command.Parameters.AddWithValue("@password", member.password);

        conn.Open();
        int result = command.ExecuteNonQuery();
        conn.Close();

        return result;
    }
    
    public Member Read(int id)
    {
        string sql = "SELECT * FROM members " +
                     "WHERE id = @id";
        
        SQLiteCommand command = new SQLiteCommand(sql,conn);
        command.Parameters.AddWithValue("@id", id);

        conn.Open();
        SQLiteDataReader reader = command.ExecuteReader();
        Member member = null;
        if(reader.Read())
        {
            member = new Member();
            member.id = Convert.ToInt32(reader["id"]);
            member.name = reader["name"].ToString();
            member.email = reader["email"].ToString();
            member.password = reader["password"].ToString();
        }
        reader.Close();
        conn.Close();

        return member;
    }

    public List<Member> SelectAll()
    {
        string sql = "SELECT * FROM members";
        
        SQLiteCommand command = new SQLiteCommand(sql,conn);

        conn.Open();
        SQLiteDataReader reader = command.ExecuteReader();
        List<Member> memberList = new List<Member>();
        while (reader.Read())
        {
            Member member = new Member();
            member.id = Convert.ToInt32(reader["id"]);
            member.name = reader["name"].ToString();
            member.email = reader["email"].ToString();
            member.password = reader["password"].ToString();
            memberList.Add(member);
        }
        reader.Close();
        conn.Close();

        return memberList;
    }
}
