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
    public partial class createacc : Form
    {
        public createacc()
        {
            InitializeComponent();
        }
        SqlConnection con5 = new SqlConnection(@"Data Source=LAPTOP-75SKL5D0;Initial Catalog=dangnhap;Integrated Security=True;MultipleActiveResultSets=true");
        void add_acc()
        {
            //con5.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con5;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = System.String.Concat("insert into tbdangnhap values(N'"+tbemail.Text+"',N'"+tbname.Text+"',N'"+tbpass.Text+"')");
            cmd2.CommandType = CommandType.Text;
            cmd2.ExecuteNonQuery();
            con5.Close();
            //con5 = null;
        }
        private void accept_Click(object sender, EventArgs e)
        {
            // pass co the trung nhung email va ten nguoi dung k duoc trung
            try
            {
                con5.Open();
                string s = "select * from tbdangnhap where ten = N'" + tbname.Text + "' or email = N'" + tbemail.Text + "'";
                SqlCommand cmd = new SqlCommand(s, con5);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    MessageBox.Show("tài khoản này đã tồn tại!!");
                    con5.Close();
                    con5 = null;
                }
                else
                {
                    add_acc();
                    MessageBox.Show("bạn đã thêm tài khoản thành công!!");
                    con5.Close();
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("sever not respond!!");
            }
            

        }

        private void done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createacc_FormClosing(object sender, FormClosingEventArgs e)
        {
            con5 = null;
        }
    }
}
