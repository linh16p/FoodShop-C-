using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace quanlibanhang
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        Config conf = Config.getInstance();
        //loginSession uid;
        public Form3()
        {
            if (loginSession.UserID == null)
            {
                Thread t = new Thread(new ThreadStart(startForm));
                t.Start();
                Thread.Sleep(5000);
                InitializeComponent();
                t.Abort();
            }
            else InitializeComponent();
            conf.Init();
        }

        public void startForm()
        {
            Application.Run(new SplashScreen());
        }

        int count = 0;

        private void Form3_Load_1(object sender, EventArgs e)
        {
            Activate();
            metroTbUserName.Focus();
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conf.simpleQuery2("SELECT * FROM dbo.taikhoan WHERE username = '" + metroTbUserName.Text + "' AND passw='" + metroTbPassword.Text + "'", 0) != null)
                {
                    int idTk = conf.simpleQuery2("SELECT * FROM dbo.taikhoan WHERE username = '" + metroTbUserName.Text + "' AND passw='" + metroTbPassword.Text + "'", 0).Rows[0].Field<int>("idtk");
                    loginSession.UserID = conf.simpleQuery2("SELECT idnv FROM dbo.taikhoan,dbo.dangnhap WHERE dbo.taikhoan.idtk = dbo.dangnhap.idtk AND dangnhap.idtk = " + idTk, 0).Rows[0].Field<int>("idnv").ToString();
                    loginSession.IDAcc = idTk.ToString();
                    MessageBox.Show("bạn đã đăng nhập thành công!!");
                    this.Hide();
                    Form frm = new formhoadon();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    count++;
                    if (count > 3)
                    {
                        DialogResult traloi;
                        traloi = MessageBox.Show("bạn chưa có tài khoản hoặc quên mật khẩu??", "question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (traloi == DialogResult.OK)
                        {
                            /*Form frm5 = new createacc();
                            frm5.ShowDialog();*/
                        }
                    }
                    MessageBox.Show("bạn đã đăng nhập thất bại!!");
                    metroTbPassword.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("lỗi không thể lấy data!");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult trloi;
            trloi = MessageBox.Show("chắc không?", "trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (trloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
