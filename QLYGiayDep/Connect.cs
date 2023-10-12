using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYGiayDep
{
    internal class Connect
    {
        private String conSql = @"Data Source=NGUYENTHITHUHUO\SQLEXPRESS;Initial Catalog=DALTNET;Integrated Security=True";
        private SqlConnection con;
        public Connect()
        {
            con = new SqlConnection(conSql);
        }
        public DataTable laydulieu(string truyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(truyvan, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool thucthi(string truyvan)
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand(truyvan, con);
                int r = cm.ExecuteNonQuery();
                con.Close();
                return r > 0;

            }
            catch
            {
                return false;
            }

        }
    }
}
