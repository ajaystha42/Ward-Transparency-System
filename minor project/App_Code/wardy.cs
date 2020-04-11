using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace minor_project
{
    public class wardy
    {
        //public DataTable GetUserByUsername(string username, string password)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\V11.0; Integrated Security=true; Database=WardDB;");
        //    SqlCommand cmd = new SqlCommand("select *from tblWardInfo where Username=@username and Password=@password", con);
        //    cmd.Parameters.AddWithValue("@username", username);
        //    cmd.Parameters.AddWithValue("@password", password);
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    con.Open();
        //    da.Fill(dt);
        //    con.Close();
        //    return dt;


        //}


        public DataTable Login(string username, string password)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@username",username),
                new SqlParameter("@password",password)

            };
            return IDU.SelectTable("select *from tblWardInfo where Username=@username and Password=@password", par, CommandType.Text);

        }

    }
}