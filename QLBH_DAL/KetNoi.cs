using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QLBH_DAL
{    public  class KetNoi
    {
        public static SqlConnection connection;
        public void MoKetNoi()
        {
            connection = new SqlConnection(@"Data Source=rangdong\dongchau;Initial Catalog=QLBH;Integrated Security=True");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else
                connection.Close();
        }
        public void DongKetNoi()
        {
            if(connection != null)
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }    
        }
        public  void ExecuteNonQuery(string query)
        {
            try
            {
                MoKetNoi();
                SqlCommand cm = new SqlCommand(query, connection);
                cm.ExecuteNonQuery();
                DongKetNoi();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public object ExecuteScalar(string query)
        {
                MoKetNoi();
                SqlCommand cm = new SqlCommand(query, connection);
                DongKetNoi();
                return (object)cm.ExecuteScalar();
        }

        public DataTable GetDataTable(string query)
        {
            try
            {
                MoKetNoi();
                DataTable tb = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(tb);
                DongKetNoi();
                return tb;
            }
            catch
            {
                return null;
            }
        }
        public string GetValue(string query)
        {
            try
            {
                MoKetNoi();
                string temp = null;
                SqlCommand cm = new SqlCommand(query, connection);
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    temp = dr[0].ToString();
                }
                DongKetNoi();
                return temp;
            }
            catch(Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error");   
            }
        }
        public int Check_LogIn(string query)
        {
                MoKetNoi();
                SqlCommand cm = new SqlCommand(query, connection);
                return (int)cm.ExecuteScalar();
                DongKetNoi();
        }
    }
}
