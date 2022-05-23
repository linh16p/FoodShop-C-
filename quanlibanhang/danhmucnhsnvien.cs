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
    public partial class danhmucnhsnvien : Form
    {
        public danhmucnhsnvien()
        {
            InitializeComponent();
        }
        SqlConnection con7 = new SqlConnection(@"Data Source=LAPTOP-75SKL5D0;Initial Catalog=qlbanhang;Integrated Security=True");
        SqlDataAdapter danv = null;
        DataTable dtnv = null;
        SqlDataAdapter dagt = null;
        DataTable dtgt = null;
        bool them;
        void loaddata()
        {
            //con7.Open();
            try
            {

                
                /*dagt = new SqlDataAdapter("select DISTINCT gioitinh from nhanvien", con7);
                dtgt = new DataTable();
                dtgt.Clear();
                dagt.Fill(dtgt);
                //cbsex.DataSource = dtgt;
                (dgvnhanvien.Columns["gioitinh"] as DataGridViewComboBoxColumn).DataSource = dtgt;
                (dgvnhanvien.Columns["gioitinh"] as DataGridViewComboBoxColumn).DisplayMember = "gioitinh";
                (dgvnhanvien.Columns["gioitinh"] as DataGridViewComboBoxColumn).ValueMember = "nhanvien";*/
                //int c = dgvnhanvien.CurrentCell.RowIndex;
                //dateTimePicker1.Value = (DateTime)dgvnhanvien.Rows[c].Cells[4].Value;
                danv = new SqlDataAdapter("select * from nhanvien", con7);
                dtnv = new DataTable();
                dtnv.Clear();
                danv.Fill(dtnv);
                dgvnhanvien.DataSource = dtnv;
                //cac nut ko duoc dung
                this.btcancel.Enabled = false;
                this.btsave.Enabled = false;
                this.panel1.Enabled = false;
                // cac nut duoc dung
                this.btADD.Enabled = true;
                this.btEdit.Enabled = true;
                this.btdelete.Enabled = true;
                this.btthoat.Enabled = true;
                //up_cbbox();
            }
            catch (SqlException)
            {
                MessageBox.Show("loi khong ket noi dc voi sever!");
            }
            //con7.Close();
        }
        private void btreload_Click(object sender, EventArgs e)
        {
            //dateTimePicker1.ResetText();
            loaddata();
            //up_cbbox();
        }

        private void danhmucnhsnvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtnv.Dispose();
            dtnv = null;
            dtgt.Dispose();
            dtgt = null;
            con7 = null;

        }
        void up_cbbox()
        {
            
            try
            {
                con7.Open();
                //SqlCommand cmd7 = new SqlCommand("select DISTINCT gioitinh from nhanvien", con7);
                dtgt = new DataTable();
                dagt = new SqlDataAdapter("select DISTINCT gioitinh from nhanvien", con7);
                dtgt.Clear();
                dagt.Fill(dtgt);
                cbsex.DataSource = dtgt;
                cbsex.DisplayMember = "gioitinh";
                cbsex.ValueMember = "nhanvien";
                con7.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("loi ket noi");
            }
            
        }
        private void cbsex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void danhmucnhsnvien_Load(object sender, EventArgs e)
        {
            up_cbbox();
            loaddata();
           /* tbmanv.Text =*/ 
            
        }

        private void btADD_Click(object sender, EventArgs e)
        {
            them = true;
            //xoa trong cac doi tuong tren cac textbox
            this.tbmanv.ResetText();
            this.tbho.ResetText();
            this.tbten.ResetText();
            this.tbdiachi.ResetText();
            this.tbdienthoai.ResetText();
            // cac nut dc dung
            this.btsave.Enabled = true;
            this.btcancel.Enabled = true;
            this.panel1.Enabled = true;
            // cac nut ko dc dung
            this.btADD.Enabled = false;
            this.btEdit.Enabled = false;
            this.btdelete.Enabled = false;
            this.btthoat.Enabled = false;
            this.tbmanv.Focus();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            them = false;
            // cac nut duoc cho phep
            this.btsave.Enabled = true;
            this.btcancel.Enabled = true;
            this.panel1.Enabled = true;
            // cac nut ko duoc cho phep
            this.btADD.Enabled = false;
            this.btEdit.Enabled = false;
            this.btdelete.Enabled = false;
            this.btthoat.Enabled = false;
            // dua du lieu len combobox
            /*this.cbsex.DataSource = dtgt;
            this.cbsex.DisplayMember = "gioitinh";
            this.cbsex.ValueMember = "nhanvien";*/
            // dong hien tai tren datagridview
            int r = dgvnhanvien.CurrentCell.RowIndex;
            tbmanv.Text = dgvnhanvien.Rows[r].Cells[0].Value.ToString();
            tbho.Text = dgvnhanvien.Rows[r].Cells[1].Value.ToString();
            tbten.Text = dgvnhanvien.Rows[r].Cells[2].Value.ToString();
            tbdiachi.Text = dgvnhanvien.Rows[r].Cells[5].Value.ToString();
            this.cbsex.SelectedValue = dgvnhanvien.Rows[r].Cells[3].Value.ToString();
            tbdienthoai.Text = dgvnhanvien.Rows[r].Cells[6].Value.ToString();
            dtpngaynv.Value = (DateTime)dgvnhanvien.Rows[r].Cells[4].Value;
            this.tbmanv.Focus();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            con7.Open();
            //try
            //{
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con7;
                cmd.CommandType = CommandType.Text;
                int r = dgvnhanvien.CurrentCell.RowIndex;
                string re = dgvnhanvien.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("delete from nhanvien where manv='"+re+"'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("complete!!");
            //
            //catch (SqlException)
            //{
                //MessageBox.Show("sever not respond(xoa)!");
            /////}
            con7.Close();
        }
        public string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }
        
        private void btsave_Click(object sender, EventArgs e)
        {
            con7.Open();
            if (them)
            {
                //try
                //{
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con7;
                    cmd.CommandType = CommandType.Text;
                    
                    cmd.CommandText = System.String.Concat("insert into nhanvien( manv ,ho ,ten ,gioitinh ,ngaynv ,diachi ,dienthoai) values('" + this.tbmanv.Text.ToString() + "',N'" + this.tbho.Text.ToString() + "',N'" + this.tbten.Text.ToString() + "',N'" +this.cbsex.SelectedValue+ "','@" + dtpngaynv.Text+ "',N'" + this.tbdiachi.Text.ToString()+"','"+this.tbdienthoai.Text.ToString()+"')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    loaddata();
                    MessageBox.Show("bạn đã thêm thành công!!");
                //}
                /*catch
                {
                    MessageBox.Show("sever not respond!!(them)");
                }*/
            }
            if (!them)
            {
                try
                {
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = con7;
                    cmd1.CommandType = CommandType.Text;
                    int r = dgvnhanvien.CurrentCell.RowIndex;
                    string re = dgvnhanvien.Rows[r].Cells[0].Value.ToString();
                    cmd1.CommandText = System.String.Concat("update nhanvien set ho=N'"+tbho.Text+"',ten=N'"+tbten.Text+"',gioitinh=N'"+cbsex.SelectedValue.ToString()+"',ngaynv='"+dtpngaynv.Text.ToString()+"',diachi=N'"+tbdiachi.Text+"',dienthoai='"+tbdienthoai.Text+"' where manv = '"+re+"'");
                    cmd1.CommandType = CommandType.Text;
                    cmd1.ExecuteNonQuery();
                    loaddata();
                    MessageBox.Show("đã sửa xong!!!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("sever not respond!!(sua)");
                }
            }
            con7.Close();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            // xoa trong cac doi tuong trong panel
            this.tbmanv.ResetText();
            this.tbho.ResetText();
            this.tbten.ResetText();
            this.tbdiachi.ResetText();
            this.tbdienthoai.ResetText();
            //cac nut duoc dung them sua xoa thoat
            this.btADD.Enabled = true;
            this.btEdit.Enabled = true;
            this.btdelete.Enabled = true;
            this.btthoat.Enabled = true;
            // cac nut ko duoc cho phep
            this.btsave.Enabled = false;
            this.btcancel.Enabled = false;
            this.panel1.Enabled = false;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpngaynv_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dtpngaynv.Text);
        }
    }
}
