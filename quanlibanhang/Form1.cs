using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlibanhang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void frmLogin()
        {
            Form frm = new Form3();
            frm.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void XemDanhMuc(int intDanhMuc)
        {
            Form frm = new Form5();
            frm.Text = intDanhMuc.ToString();
            frm.ShowDialog();
        }
        private void đổiMậtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void danhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void danhMụcHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);
        }

        private void danhMụcChiTiếtHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Text = "Quản lí danh mục thành phố";
            frm.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void đăngNhậpToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmLogin();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frmm = new danhmuckhachhang();
            frmm.ShowDialog();
        }

        private void đổiMậtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm5 = new capnhatacc();
            frm5.Text = "ĐỔI MẬT KHẨU";
            frm5.ShowDialog();
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm5 = new createacc();
            
            frm5.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form frm7 = new danhmucnhsnvien();

            frm7.ShowDialog();
        }
    }
}
