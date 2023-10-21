using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public class DatabaseConnect
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.Pharmacy);
        
        public DataTable LayDanhSach(string sql)
        {
            DataTable dtds = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dtds);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return dtds;
        }
        public void ThucThi(string sql)
        {
            conn.Open();
            SqlCommand cmd=new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

