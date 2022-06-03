using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlibanhang
{
    internal class Config
    {
        string connectionString = "Data Source=LAPTOP-P8R3R2QA;Initial Catalog=quanlybanhang;Integrated Security=True";
        public SqlConnection conn = null;

        public SqlConnection Init()
        {
            conn = new SqlConnection(connectionString); 
            return conn;
        }

        public DataTable simpleQuery(string query)
        {
            try
            {
                // khoi dong connection
                Init();
                // Vận chuyển dữ liệu lên DataTable dtThanhPho
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                return dt;

            }
            catch(SqlException) 
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable simpleQuery2(string query, int isSet)
        {
            try
            {
                Init();
                DataTable dt = new DataTable();
                // viet cau lenh query de lay du lieu
                SqlCommand cm = new SqlCommand(query, conn);
                //mo chuoi ket noi
                conn.Open();
                if (isSet == 0)
                {
                    // su dung phuong thuc de excuterReader lay du lieu tu sql
                    SqlDataReader sdr = cm.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        dt.Load(sdr);
                        return dt;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    // them sua hoac xoa
                    var rows_affected = cm.ExecuteNonQuery();
                    MessageBox.Show($"Số dòng ảnh hưởng = {rows_affected}");
                    return null;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Co loi xay ra !!!" + e);
                return null;
            }
            // dóng chuỗi kết nối
            finally
            {
                conn.Close();
            }
        }

        public void disconnect(DataTable dt)
        {
            if (dt != null) dt.Dispose();
            dt = null;
            conn = null;
        }

        private static Config instace;
        public static Config getInstance()
        {
            if(instace == null)
            {
                instace = new Config();
            }
            return instace;
        }

        private Config() { }
    }
}
