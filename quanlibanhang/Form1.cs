using System;
using System.Data;
using System.Windows.Forms;

namespace quanlibanhang
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Config conf = Config.getInstance();
        public Form1()
        {
            InitializeComponent();
            conf.Init();
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        bool them = false, sua = false;

        private void btReload_Click(object sender, EventArgs e)
        {
            loadData();

        }

        private void loadData()
        {
            metroGridNv.DataSource = conf.simpleQuery2("SELECT dbo.nhanvien.idnv,dbo.taikhoan.idtk,tennv,sdt,diachi,email,username,passw,roles,dbo.nhanvien.trangthai AS TrangthaiNV FROM dbo.nhanvien,dbo.taikhoan,dbo.dangnhap WHERE dbo.nhanvien.idnv = dbo.dangnhap.idnv AND dbo.taikhoan.idtk = dbo.dangnhap.idtk", 0);
        }

        private void metroGridNv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = metroGridNv.CurrentCell.RowIndex;
            metroTbTenNv.Text = metroGridNv.Rows[r].Cells[2].Value.ToString();
            metroTbPhone.Text = metroGridNv.Rows[r].Cells[3].Value.ToString();
            metroTbAdress.Text = metroGridNv.Rows[r].Cells[4].Value.ToString();
            metroTbEmail.Text = metroGridNv.Rows[r].Cells[5].Value.ToString();
            metroTbUserName.Text = metroGridNv.Rows[r].Cells[6].Value.ToString();
            metroTbPass.Text = metroGridNv.Rows[r].Cells[7].Value.ToString();
            metroTbConfirmPass.Text = metroGridNv.Rows[r].Cells[7].Value.ToString();

            if (metroGridNv.Rows[r].Cells[8].Value.ToString() == "False")
                metroRbNoAdmin.Checked = true;
            else metroRbAdmin.Checked = true;

            if (metroGridNv.Rows[r].Cells[9].Value.ToString() == "False")
                metroRbDead.Checked = true;
            else metroRbActive.Checked = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroBtAddNv.Enabled = false;
            sua = true;
        }

        private void metroBtClear_Click(object sender, EventArgs e)
        {
            metroTbTenNv.Clear();
            metroTbPhone.Clear();
            metroTbAdress.Clear();
            metroTbEmail.Clear();
            metroTbUserName.Clear();
            metroTbPass.Clear();
            metroTbConfirmPass.Clear();
            metroRbActive.Checked = false;
            metroRbDead.Checked = false;
            metroRbAdmin.Checked = false;
            metroRbNoAdmin.Checked = false;
        }

        private void metroBtAddNv_Click(object sender, EventArgs e)
        {
            metroBtEditNv.Enabled = false;
            them = true;
            metroBtSave.Enabled = true;
        }

        private void metroBtSave_Click(object sender, EventArgs e)
        {
            if (them)
            {
                if (metroTbTenNv.Text != "" && metroTbPhone.Text != "" && metroTbAdress.Text != "" && metroTbEmail.Text != "" && metroTbUserName.Text != "" && metroTbPass.Text != "" && metroTbConfirmPass.Text != "" && IsNumber(metroTbPhone.Text) && metroTbPass.Text == metroTbConfirmPass.Text)
                {
                    int danglam = metroRbActive.Checked == true ? 1 : 0;
                    int admin = metroRbAdmin.Checked == true ? 1 : 0;

                    conf.simpleQuery2("INSERT INTO dbo.nhanvien(tennv,sdt,diachi,email,trangthai)VALUES(N'" + metroTbTenNv.Text + "'," + metroTbPhone.Text + ",N'" + metroTbAdress.Text + "','" + metroTbEmail.Text + "'," + danglam + ")", 1);
                    conf.simpleQuery2("INSERT INTO dbo.taikhoan(username,passw,roles,trangthai)VALUES('" + metroTbUserName.Text + "','" + metroTbPass.Text + "'," + admin + ",1)", 1);

                    int idnv = conf.simpleQuery2("select top 1 idnv FROM dbo.nhanvien order by idnv DESC", 0).Rows[0].Field<int>("idnv");
                    int idtk = conf.simpleQuery2("select top 1 idtk FROM dbo.taikhoan order by idtk DESC", 0).Rows[0].Field<int>("idtk");

                    conf.simpleQuery2("INSERT INTO dbo.dangnhap(idnv,idtk)VALUES(" + idnv + "," + idtk + ")", 1);

                    MessageBox.Show("Them thanh cong roi be oi!");
                    loadData();
                    metroBtEditNv.Enabled = true;
                    metroBtSave.Enabled = false;
                    them = false;
                }
                else MessageBox.Show("Không ổn rồi bé ơi, nhập sai một trường thông tin nào đó mất rồi!, Hãy nhập đúng nhé", "Thông báo");
            }
            else if (sua)
            {
                if (metroTbTenNv.Text != "" && metroTbPhone.Text != "" && metroTbAdress.Text != "" && metroTbEmail.Text != "" && metroTbUserName.Text != "" && metroTbPass.Text != "" && metroTbConfirmPass.Text != "" && IsNumber(metroTbPhone.Text) && metroTbPass.Text == metroTbConfirmPass.Text)
                {
                    int danglam = metroRbActive.Checked == true ? 1 : 0;
                    int admin = metroRbAdmin.Checked == true ? 1 : 0;

                    conf.simpleQuery2("UPDATE dbo.nhanvien SET tennv = N'" + metroTbTenNv.Text + "', sdt = " + metroTbPhone.Text + ",diachi = N'" + metroTbAdress.Text + "',email = '" + metroTbEmail.Text + "',trangthai = " + danglam + " WHERE email = '" + metroTbEmail.Text + "'", 1);
                    conf.simpleQuery2("UPDATE dbo.taikhoan SET username = '" + metroTbUserName.Text + "', passw='" + metroTbPass.Text + "',roles=" + admin + ", trangthai=" + danglam + " WHERE username = '" + metroTbUserName.Text + "'", 1);

                    MessageBox.Show("Sua thanh cong roi be oi!");
                    loadData();
                    metroBtAddNv.Enabled = true;
                    metroBtSave.Enabled = false;
                    sua = false;
                }
                else MessageBox.Show("Không ổn rồi bé ơi, nhập sai một trường thông tin nào đó mất rồi!, Hãy nhập đúng nhé", "Thông báo");

            }
        }

        private void metroBtCancel_Click(object sender, EventArgs e)
        {
            metroBtAddNv.Enabled = true;
            metroBtEditNv.Enabled = true;
            them = false;
            sua = false;
        }

        private void metroBtEditNv_Click(object sender, EventArgs e)
        {
            metroBtAddNv.Enabled = false;
            sua = true;
            metroBtSave.Enabled = true;
        }

        private void metroBtReload_Click(object sender, EventArgs e)
        {
            loadData();
        }

    }
}
