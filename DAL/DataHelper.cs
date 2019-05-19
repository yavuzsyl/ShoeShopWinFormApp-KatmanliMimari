using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataHelper
    {
        private static SqlConnection sqlConnection;

        public static SqlConnection  SqlConnection
        {
            get {
                if (sqlConnection==null)
                {
                    sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
                }
                return sqlConnection;
            }
            set { sqlConnection = value; }
        }

        public static DataTable Select(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, SqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            
        }

        public static bool ExecuteCommand(string sql,params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql,SqlConnection);
            cmd.Parameters.AddRange(parameters);
            try
            {
                if (SqlConnection.State==ConnectionState.Closed)
                    SqlConnection.Open();

                int s= cmd.ExecuteNonQuery();
                if (s > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                return false;
            }
            finally
            {
                if(SqlConnection.State==ConnectionState.Open)
                SqlConnection.Close();
            }


        }
    }
}
