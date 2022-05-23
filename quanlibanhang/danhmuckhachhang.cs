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
    public partial class danhmuckhachhang : Form
    {
        public danhmuckhachhang()
        {
            InitializeComponent();
        }
        SqlConnection con6 = new SqlConnection(@"Data Source=LAPTOP-75SKL5D0;Initial Catalog=qlbanhang;Integrated Security=True");
        
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlDataAdapter dakh = null;
        DataTable dtkh = null;
        bool them;
        void loaddata()
        {
            //con6.Open();
            da = new SqlDataAdapter("select * from thanhPho",con6);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            //dua du lieu len combox trong datagridview
            (dgvkhachhang.Columns["thanhpho"] as DataGridViewComboBoxColumn).DataSource = dt;
            (dgvkhachhang.Columns["thanhpho"] as DataGridViewComboBoxColumn).DisplayMember = "tenthanhpho";
            (dgvkhachhang.Columns["thanhpho"] as DataGridViewComboBoxColumn).ValueMember = "thanhPho";
            //van chuyen du lieu vao datagridview khachhang
            dakh = new SqlDataAdapter("select * from khachhang",con6);
            dtkh = new DataTable();
            dtkh.Clear();
            dakh.Fill(dtkh);
            
            // dua du lieu len datagridview
            dgvkhachhang.DataSource = dtkh;
            // xoa trong cac doi tuong trong panel
            this.tbmakh.ResetText();
            this.tbtencty.ResetText();
            this.tbdiachi.ResetText();
            this.tbdienthoai.ResetText();
            // khong cho cac nut luu va huy hoat dong
            this.btsave.Enabled = false;
            this.btcancel.Enabled = false;
            this.panel1.Enabled = false;
            // cho thao tac tre cac nut con lai hoat dong
            this.btADD.Enabled = true;
            this.btEdit.Enabled = true;
            this.btdelete.Enabled = true;
            this.btthoat.Enabled = true;
            //show_in_combobox();
            //con6.Close();
        }
        void show_in_combobox()
        {
            try
            {
                //con6.Open();
                con6.Open();
                string s = "select * from thanhPho";
                da = new SqlDataAdapter(s, con6);
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                this.cbthanhpho.DataSource = dt;
                this.cbthanhpho.DisplayMember = "tenthanhpho";
                this.cbthanhpho.ValueMember = "thanhPho";
                con6.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("error", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void danhmuckhachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlbanhangDataSet.thanhPho' table. You can move, or remove it, as needed.
            //this.thanhPhoTableAdapter.Fill(this.qlbanhangDataSet.thanhPho);
            show_in_combobox();
            loaddata();
        }

        private void cbthanhpho_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btADD_Click(object sender, EventArgs e)
        {
            // kich hoat bien them
            them = true;
            // xoa trong cac doi tuong trong panel
            this.tbmakh.ResetText();
            this.tbmakh.ResetText();
            this.tbtencty.ResetText();
            this.tbdiachi.ResetText();
            this.tbdienthoai.ResetText();
            // cho thao tac tren nut luu/huy/thoat hoat dong
            this.btcancel.Enabled = true;
            this.btsave.Enabled = true;
            this.panel1.Enabled = true;
            // khong cho cac nut con lai hoat dong
            this.btADD.Enabled = false;
            this.btEdit.Enabled = false;
            this.btdelete.Enabled = false;
            this.btthoat.Enabled = false;
            //dua du lieu len combo box
            //show_in_combobox();
            this.tbmakh.Focus();
        }

        private void btreload_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            them = false;
            // đưa dữ liệu lên combobox
            //show_in_combobox();
            this.panel1.Enabled = true; // cho phep thao tac tren panel
            // thu tu dong hien tai 
            int r = dgvkhachhang.CurrentCell.RowIndex;
            this.tbmakh.Text = dgvkhachhang.Rows[r].Cells[0].Value.ToString();
            this.tbtencty.Text = dgvkhachhang.Rows[r].Cells[1].Value.ToString();
            this.tbdiachi.Text = dgvkhachhang.Rows[r].Cells[2].Value.ToString();
            this.cbthanhpho.SelectedValue = dgvkhachhang.Rows[r].Cells[3].Value.ToString();
            this.tbdienthoai.Text = dgvkhachhang.Rows[r].Cells[4].Value.ToString();
            //cho phép thao tác trên cac nút lưu/hủy/panel
            this.btsave.Enabled = true;
            this.btcancel.Enabled = true;
            this.panel1.Enabled = true;
            // ko cho phep cac nut con lai
            this.btADD.Enabled = false;
            this.btdelete.Enabled = false;
            this.btEdit.Enabled = false;
            this.btthoat.Enabled = false;
            this.tbmakh.Focus();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            con6.Open();
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con6;
                cmd.CommandType = CommandType.Text;
                // lay ra thu tu record hien hanh
                int r = dgvkhachhang.CurrentCell.RowIndex;
                string s = dgvkhachhang.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("delete from khachhang where makh = '"+s+"'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("đã xóa xong nhé!!");
            }
            catch (SqlException)
            {
                MessageBox.Show("sever not respond!","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con6.Close();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            // xoa trong cac doi tuong trong panel
            this.tbmakh.ResetText();
            this.tbtencty.ResetText();
            this.tbdiachi.ResetText();
            this.tbdienthoai.ResetText();
            //cho thao tac tren cac nut them / sua / xoa / thoat
            this.btADD.Enabled = true;
            this.btEdit.Enabled = true;
            this.btdelete.Enabled = true;
            this.btthoat.Enabled = true;
            // khong cho thao tac tren cac nut luu /huy/ panel
            this.btsave.Enabled = false;
            this.btcancel.Enabled = false;
            this.panel1.Enabled = false;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            con6.Open();
            if (them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con6;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("insert into khachhang values('"+tbmakh.Text.ToString()+"',N'"+tbtencty.Text.ToString()+"',N'"+tbdiachi.Text.ToString()+"','"+cbthanhpho.SelectedValue.ToString()+"','"+tbdienthoai.Text.ToString()+"')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    loaddata();
                    MessageBox.Show("Lưu thành công!","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("sever not respond!");
                }
            }
            if (!them)
            {
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con6;
                    cmd.CommandType = CommandType.Text;
                    // Thứ tự dòng hiện hành
                    int r = dgvkhachhang.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string strMAKH = dgvkhachhang.Rows[r].Cells[0].Value.ToString();
                    // Câu lệnh SQL
                    cmd.CommandText = System.String.Concat("Update khachhang Set tencty = '"+this.tbtencty.Text.ToString() + "', diachi=N'" + this.tbdiachi.Text.ToString() + "',thanhpho = N'" + this.cbthanhpho.SelectedValue.ToString() + "',dienthoai = '" + this.tbdienthoai.Text.ToString() + "' Where makh = '" + strMAKH + "'");
                    // Cập nhật
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    loaddata(); MessageBox.Show("Đã sửa xong!");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }
            }
                con6.Close();
         }

        private void dgvkhachhang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhmuckhachhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            dt.Dispose();
            dtkh.Dispose();
            dt = null;
            dtkh = null;
            con6 = null;
        }
    }
}
