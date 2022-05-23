using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace quanlibanhang
{
    public partial class quenmk : Form
    {
        public quenmk()
        {
            InitializeComponent();
        }
        SqlConnection con4 = new SqlConnection(@"Data Source=LAPTOP-75SKL5D0;Initial Catalog=dangnhap;Integrated Security=True;MultipleActiveResultSets=true");
        /*SqlDataAdapter da = null;
        DataTable dt = null;*/
        void kt()
        {
            /*da = new SqlDataAdapter("select pass from dangnhap where ten = N'" + tbtennd.Text + "' and email=N'" + tbmatkhaucu.Text + "'", con4);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);*/
            con4.Open();
            SqlCommand cmd8 = new SqlCommand("select pass from dangnhap where ten = N'" + tbtennd.Text + "' and email=N'" + tbmatkhaucu.Text + "'", con4);

            
        }
        void doi()
        {
            con4.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con4;
            cmd1.CommandText = System.String.Concat("update tbdangnhap set pass=N'" + tbmatkhaumoi.Text.ToString() + "' where ten =N'" + tbtennd.Text.ToString() + "' and email = N'" + tbmatkhaucu.Text.ToString() + "'");
            cmd1.CommandType = CommandType.Text; //con4.Close();
            cmd1.ExecuteNonQuery();
            con4.Close();
        }
        private void quenmk_Load(object sender, EventArgs e)
        {

        }
        bool check5()
        {
            con4.Open();
            SqlCommand cmd9 = new SqlCommand("select * from tbdangnhap where ten = N'" + tbtennd.Text + "' and email=N'" + tbmatkhaucu.Text + "' and pass =N'" + tbmatkhaumoi.Text.ToString() + "'", con4);
            SqlDataReader dtr = cmd9.ExecuteReader();
            if (dtr.Read() == true)
            {
                con4.Close();
                return false;
            }
            { con4.Close(); return true; }
        }
        private void btlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con4 = new SqlConnection(@"Data Source=LAPTOP-75SKL5D0;Initial Catalog=dangnhap;Integrated Security=True;MultipleActiveResultSets=true");
            try
            {
                con4.Open();
                string sql = "select * from tbdangnhap where ten = N'" + tbtennd.Text + "' and email=N'" + tbmatkhaucu.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con4);
                SqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read() == true)
                {
                    if(!check5())
                    {
                        MessageBox.Show("mật khẩu mới không được trùng với mật khẩu cũ!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbmatkhaumoi.Focus();
                    }
                    else if (tbmatkhaumoi.Text != tbxacnhan.Text)
                    {
                        MessageBox.Show("mật khẩu xác nhận không khớp!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxacnhan.Focus();
                    }
                    else
                    {
                        doi();
                        MessageBox.Show("đã đổi mật khẩu thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("bạn nhập sai tên người dùng hoặc email!","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    tbtennd.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("lỗi kết nối !!!");
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quenmk_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            con4 = null;
        }
    }
}
