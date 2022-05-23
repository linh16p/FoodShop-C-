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
    public partial class capnhatacc : Form
    {
        public capnhatacc()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void capnhatacc_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con4 = new SqlConnection(@"Data Source=LAPTOP-75SKL5D0;Initial Catalog=dangnhap;Integrated Security=True;MultipleActiveResultSets=true");
        void doi()
        {
            con4.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con4;
            cmd1.CommandText = System.String.Concat("update tbdangnhap set pass=N'" + tbmatkhaumoi.Text.ToString() + "' where ten =N'" + tbtennd.Text.ToString() + "' and pass = N'" + tbmatkhaucu.Text.ToString() + "'");
            cmd1.CommandType = CommandType.Text; //con4.Close();
            cmd1.ExecuteNonQuery();
            con4.Close();
        }
        private void btlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con4 = new SqlConnection(@"Data Source=LAPTOP-75SKL5D0;Initial Catalog=dangnhap;Integrated Security=True;MultipleActiveResultSets=true");
            try
            {
                con4.Open();
                string sql = "select * from tbdangnhap where ten = N'" + tbtennd.Text + "' and pass=N'" + tbmatkhaucu.Text + "'";
                SqlCommand cmd = new SqlCommand(sql,con4);
                SqlDataReader dtr = cmd.ExecuteReader();
                
                SqlDataAdapter da = null;
                DataTable dt = null;
                if (dtr.Read() == true)
                {
                    if(tbmatkhaumoi.Text == tbmatkhaucu.Text)
                    {
                        MessageBox.Show("mật khẩu mới không được trùng với mật khẩu cũ!!","thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbmatkhaumoi.Focus();
                    }
                    else
                    {
                        if (tbmatkhaumoi.Text != tbxacnhan.Text)
                        {
                            MessageBox.Show("mật khẩu không khớp!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxacnhan.Focus();
                        }
                        else
                        {
                            /*cmd.CommandType = CommandType.Text;
                            cmd.Connection = con4;*/
                            /*cmd.CommandText = System.String.Concat("update tbdangnhap set pass=N'" + tbmatkhaumoi.Text.ToString() + "' where ten =N'" + tbtennd.Text.ToString() + "' and pass = N'" + tbmatkhaucu.Text.ToString() + "'");
                            cmd.CommandType = CommandType.Text; //con4.Close();
                            cmd.ExecuteNonQuery();*/
                            //con4.Close();
                            doi();
                            MessageBox.Show("đã đổi mật khẩu thành công!");
                            da = new SqlDataAdapter("select * from tbdangnhap",con4);
                            dt = new DataTable();
                            dt.Clear();
                            da.Fill(dt);
                            dgvdangnhap.DataSource = dt;
                            dgvdangnhap.AutoResizeColumns();
                            dt.Dispose();
                            dt = null;

                            con4.Close();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("không có người này trong databases!");
                    tbtennd.Focus();
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("lỗi kết nối !!!");
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void capnhatacc_FormClosing(object sender, FormClosingEventArgs e)
        {
            con4 = null;
        }
    }
}
