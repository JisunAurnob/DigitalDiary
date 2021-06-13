using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalDiary
{
    class DbConnection
    {
        public SqlConnection con;
        SqlCommand command;
        public DbConnection()
        {
            this.con = new SqlConnection(ConfigurationManager.ConnectionStrings["digitalDiary"].ConnectionString);
            this.con.Open();
        }
        public void CloseConnection()
        {
            this.con.Close();
        }
        public int AddUser(params string[] inputs)
        {
            string sql = "INSERT INTO Users(Name,Username,Password,Gender,DateOfBirth,BloodGroup,Picture) VALUES('" + inputs[0] + "','" + inputs[1] + "','" + inputs[2] + "','" + inputs[3] + "','" + inputs[4] + "','" + inputs[5] + "','" + inputs[6] + "')";
            command = new SqlCommand(sql, con);
            int result = command.ExecuteNonQuery();
            return result;
        }
        public DataTable GetAllEvent(string username)
        {
            string sql = "SELECT * FROM EventDetails WHERE Username='" + username + "'";
            SqlCommand cmd = new SqlCommand(sql, this.con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        
    }
}
