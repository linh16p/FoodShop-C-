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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //this.FormClosing += Form3_FormClosing;
        }

        int count = 0;
        //Form fm;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=LAPTOP-75SKL5D0;Initial Catalog=dangnhap;Integrated Security=True");
            try
            {
                con2.Open();
                string sql = "select * from tbdangnhap where ten = '" + textBox2.Text + "' and pass='"+ textBox1.Text +"'";
                SqlCommand cmd = new SqlCommand(sql, con2);
                SqlDataReader dt = cmd.ExecuteReader();
                if(dt.Read() == true)
                {
                    MessageBox.Show("bạn đã đăng nhập thành công!!");
                    con2.Close();
                    con2 = null;
                    //this.Close();
                    this.Hide();
                    Form frm = new hoadon();
                    frm.ShowDialog();
                    this.Close();

                }
                else
                {
                    count++;
                    if(count > 3)
                    {
                        DialogResult traloi;
                        traloi = MessageBox.Show("bạn chưa có tài khoản hoặc quên mật khẩu??","question", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                        if(traloi == DialogResult.OK)
                        {
                            Form frm5 = new createacc();
                            frm5.ShowDialog();
                        }
                    }
                    MessageBox.Show("bạn đã đăng nhập thất bại!!");
                    con2.Close();
                    textBox1.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("lỗi không thể lấy data!");
            }
           /* if (count > 3)
            {
                MessageBox.Show(" đăng nhập thành công!!");
                this.Close();
            }
            else if ((this.textBox2.Text =="linhtinh") && (this.textBox1.Text =="123"))
            {
                    MessageBox.Show(" đăng nhập thành công!!");
                    this.Close();
            }
            else
            {
                    count++;
                    MessageBox.Show("bạn nhập không đúng người dùng/ mật khẩu!!!");
                    this.textBox1.Focus();
             }*/
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult trloi;
            trloi = MessageBox.Show("chắc không?", "trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (trloi == DialogResult.OK)
                Application.Exit();
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void linktaotaikhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm5 = new createacc();

            frm5.ShowDialog();
        }

        private void linkfoget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm5 = new quenmk();
            frm5.Text = "ĐỔI MẬT KHẨU";
            frm5.ShowDialog();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*DialogResult trloi;
            trloi = MessageBox.Show("bạn có muốn thoát form đăng nhập không?", "trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (trloi == DialogResult.OK) Application.Exit();*/

            //this.Close();

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {

            /*if (e.CloseReason == CloseReason.WindowsShutDown) return;
            //DialogResult trl;
            //trl = MessageBox.Show("chắc không?", "trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ((MessageBox.Show("bạn có muốn thoát form đăng nhập không?", "trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes))
                e.Cancel = true;*/
            //In case windows is trying to shut down, don't hold the process up
            /*if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult == DialogResult.Cancel)
            {
                // Assume that X has been clicked and act accordingly.
                // Confirm user wants to close
                switch (MessageBox.Show(this, "Are you sure?", "Do you still want ... ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Stay on this form
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }*/
            
        }
    }
}
