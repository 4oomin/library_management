using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement
{
    public class Member
    {
        public int ID;
        public string Name; 
        public string Email;
        public string PassWord;
        public Member()
        { 
            this.ID = 0;
            this.Name = "";
            this.Email = "";
            this.PassWord = "";
        }

        public const string DBpath = @"Data Source=C:\Sqlite3\DataBase\LibManageDB.sqlite;Version=3;";
        public SQLiteConnection conn = new SQLiteConnection(DBpath);

        public bool MemberCreate()
        {
            int result;
            SQLiteCommand command;

            string sql = "INSERT INTO members (name, email, password) VALUES (@Name, @Email, @PassWord)";
            command = new SQLiteCommand(sql, conn);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PassWord", PassWord);

            conn.Open();
            result = command.ExecuteNonQuery();
            conn.Close();
            
            return true;
        }

        public Member MemberRead()
        {
            Member mem = null;

            string sql = "SELECT * FROM members WHERE email = @Email";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.Parameters.AddWithValue("@Email", Email);

            conn.Open();
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                mem = new Member();
                mem.ID = Convert.ToInt32(reader["id"]);
                mem.Name = reader["name"].ToString();
                mem.Email = reader["email"].ToString();
                mem.PassWord = reader["password"].ToString();
            }
            reader.Close();
            conn.Close();

            return mem;
        }

        public bool MemberDelete()
        {
            int result;
            SQLiteCommand command;

            string sql = "DELETE FROM members WHERE email = @Email";
            command = new SQLiteCommand(sql, conn);
            command.Parameters.AddWithValue("@Email", Email);

            conn.Open();
            result = command.ExecuteNonQuery();
            conn.Close();

            return true;
        }

        public List<Member> MemberList()
        {
            List<Member> memList = new List<Member>();

            string sql = "SELECT id, name, email, password FROM members";
            SQLiteCommand command = new SQLiteCommand(sql, conn);

            conn.Open();
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Member mem = new Member();
                mem.ID = Convert.ToInt32(reader["id"]);
                mem.Name = reader["name"].ToString();
                mem.Email = reader["email"].ToString();
                mem.PassWord = reader["password"].ToString();

                memList.Add(mem);
            }

            reader.Close();
            conn.Close();

            return memList;
        }

    }


}
