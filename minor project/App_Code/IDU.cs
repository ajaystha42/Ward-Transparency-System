using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace minor_project
{
    public static class IDU
    {

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\V11.0; Integrated Security=true; Database=WardDB;");

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;


        }

        public static DataTable SelectTable( string sql,SqlParameter[] par,CommandType cmdtype)
        {
            using (SqlConnection con = GetConnection())
            {
                using(SqlCommand cmd=new SqlCommand(sql,con))
                {
                    DataTable dt = new DataTable();
                    cmd.CommandType = cmdtype;
                    if (par != null)
                    {
                        cmd.Parameters.AddRange(par);

                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        return dt;

                    }
                 
                    



                }

            }

        }



        public static int ReturnInteger(string sql, SqlParameter[] par, CommandType cmdtype)
        {

            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = cmdtype;
                    if (par != null)
                    {
                        cmd.Parameters.AddRange(par);


                    }

                    int i = cmd.ExecuteNonQuery();
                    return i;

                }

            }




        }

    }
}