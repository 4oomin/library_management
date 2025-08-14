public class CirculateRepository : IRepository<Circulate>
{
    public const string path = @"_put your own path_;";
    private SQLiteConnection conn;

    public CirculateRepository()
    {
        conn = new SQLiteConnection(path);
    }
    public int Create(Circulate circulate)
    {
        string sql = "INSERT INTO circulates (member_id, book_id, start_date, end_date) " +
                     "VALUES (@member_id, @book_id, @startDate, @endDate)";
        
        SQLiteCommand command = new SQLiteCommand(sql,conn);
        command.Parameters.AddWithValue("@member_id", circulate.memberId);
        command.Parameters.AddWithValue("@book_id", circulate.bookId);
        command.Parameters.AddWithValue("@startDate", circulate.startDate);
        command.Parameters.AddWithValue("@endDate", circulate.endDate);
        
        conn.Open();
        int result = command.ExecuteNonQuery();
        conn.Close();

        return result;
    }

    public int Delete(Circulate circulate)
    {
        string sql = "DELETE FROM circulates " +
                     "WHERE member_id = @member_id AND book_id = @book_id";
        
        SQLiteCommand command = new SQLiteCommand(sql,conn);
        command.Parameters.AddWithValue("@member_id", circulate.memberId);
        command.Parameters.AddWithValue("@book_id",circulate.bookId);

        conn.Open();
        int result = command.ExecuteNonQuery();
        conn.Close();

        return result;
    }
    
    public Circulate Read(int id)
    {
        string sql = "SELECT * FROM circulates " +
                     "WHERE id = @id";
        
        SQLiteCommand command = new SQLiteCommand(sql,conn);
        command.Parameters.AddWithValue("@id", id);

        conn.Open();
        SQLiteDataReader reader = command.ExecuteReader();
        Circulate circulate = null;
        if(reader.Read())
        {
            circulate = new Circulate();
            circulate.id = Convert.ToInt32(reader["id"]);
            circulate.name = reader["name"].ToString();
            circulate.title = reader["title"].ToString();
            circulate.startDate = reader["start_date"].ToString();
            circulate.endDate = reader["end_date"].ToString();
        }
        reader.Close();
        conn.Close();

        return circulate;
    }

    public List<Circulate> SelectAll()
    {
        string sql = "SELECT * FROM circulates";
        
        SQLiteCommand command = new SQLiteCommand(sql,conn);

        conn.Open();
        SQLiteDataReader reader = command.ExecuteReader();
        List<Circulate> circulateList = new List<Circulate>();
        while (reader.Read())
        {
            Circulate circulate = new Circulate();
            circulate.id = Convert.ToInt32(reader["id"]);
            circulate.memberId = reader["member_id"].ToString();
            circulate.bookId = reader["book_id"].ToString();
            circulate.startDate = reader["start_date"].ToString();
            circulate.endDate = reader["end_date"].ToString();
            circulateList.Add(circulate);
        }
        reader.Close();
        conn.Close();

        return circulateList;
    }
}
