using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement
{
    public class Circulate
    {
        public int ID;
        public string Name;
        public string Title;
        public string StartDate;
        public string EndDate;

        public Circulate()
        {
            ID = 0;
            Name = "";
            Title = "";
            StartDate = "";
            EndDate = "";
        }

        public const string DBpath = @"Data Source=C:\Sqlite3\DataBase\LibManageDB.sqlite;Version=3;";
        public SQLiteConnection conn = new SQLiteConnection(DBpath);

        public bool CirculateCreate()
        {
            int result;
            SQLiteCommand command;

            string sql = "INSERT INTO circulates (name,title,startdate,enddate) " +
                         "VALUES (@Name, @Title, @Startdate, @Enddate)";
            command = new SQLiteCommand(sql, conn);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Title",Title);
            command.Parameters.AddWithValue("@Startdate",StartDate);
            command.Parameters.AddWithValue("@Enddate", EndDate);

            conn.Open();
            result = command.ExecuteNonQuery();
            conn.Close();

            return true;
        }

        public Circulate CirculateRead()
        {
            Circulate cir = null;

            string sql = "SELECT * FROM circulates " +
                         "WHERE name = @Name AND title = @Title";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.Parameters.AddWithValue("@Name",this.Name);
            command.Parameters.AddWithValue("@Title",this.Title);
            conn.Open();
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                cir = new Circulate();
                cir.ID = Convert.ToInt32(reader["id"]);
                cir.Name = reader["name"].ToString();
                cir.Title = reader["title"].ToString();
                cir.StartDate = reader["startdate"].ToString();
                cir.EndDate = reader["enddate"].ToString();

            }
            reader.Close();
            conn.Close();

            return cir;
        }

        public bool CirculateDelete()
        {
            int result;
            SQLiteCommand command;

            string sql = "DELETE FROM circulates " +
                         "WHERE name = @Name AND title = @Title";
            command = new SQLiteCommand(sql, conn);
            command.Parameters.AddWithValue("@Name", this.Name);
            command.Parameters.AddWithValue("@Title",this.Title);

            conn.Open();
            result = command.ExecuteNonQuery();
            conn.Close();

            return true;
        }

        public List<Circulate> CirculateList()
        {
            List<Circulate> circulateList = new List<Circulate>();

            string sql = "SELECT * FROM circulates";
            SQLiteCommand command = new SQLiteCommand(sql, conn);

            conn.Open();
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Circulate cir = new Circulate();
                cir.ID = Convert.ToInt32(reader["id"]);
                cir.Name = reader["name"].ToString();
                cir.Title = reader["title"].ToString();
                cir.StartDate = reader["startdate"].ToString();
                cir.EndDate = reader["enddate"].ToString();

                circulateList.Add(cir);
            }

            reader.Close();
            conn.Close();

            return circulateList;
        }

    }
}
