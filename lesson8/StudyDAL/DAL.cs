using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDAL
{
    public class DAL
    {
        private static SqlConnection con ()
        {
            return new SqlConnection("Server=.\\SQLEXPRESS;Initial Catalog=study;Integrated Security=SSPI");
        }

        public string ExecuteScalar(string str, SqlParameter[] sql)
        {
            SqlConnection con = DAL.con();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(sql);
                return Convert.ToString((cmd.ExecuteScalar()));
            } catch (Exception Error)
            {
                throw Error;
            } finally
            {
                con.Close();
            }
        }
    }
}
