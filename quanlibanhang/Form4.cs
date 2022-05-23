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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string ketnoi1 = "Data source = LAPTOP-75SKL5D0; Initial Catalog = qlbanhang; Integrated Security = true";
        SqlConnection con1 = null;
        // doi tuong dua du lieu vao datatable dtthanhpho
        SqlDataAdapter dathanhpho = null;
        //doi tuong hien thi du lieu len form
        DataTable dtthanhpho = null;
        // khai bao bien kiem tra viev them hay sua du lieu
        bool check;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void loaddata()
        {
            try
            {
                con1 = new SqlConnection(ketnoi1);
                // vận chuyển dữ liệu lên datable dtthanhpho
                string q = "select * from thanhPho";
                dathanhpho = new SqlDataAdapter(q, con1);
                dtthanhpho = new DataTable();
                dtthanhpho.Clear();
                dathanhpho.Fill(dtthanhpho);
                // đưa dữ liệu lên data grid view
                dataGridView1.DataSource = dtthanhpho;
                //thay đổi độ rộng của cột
                dataGridView1.AutoResizeColumns();
                // xóa trống các đối tượng trong panel
                this.textBox1.ResetText();
                this.textBox2.ResetText();
                //không cho thao tác trên các nút lưu và hủy
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.panel1.Enabled = false;

                // cho thao tác trên thêm/sửa/xóa
                this.button2.Enabled = true;
                this.button3.Enabled = true;
                this.button6.Enabled = true;
                this.button7.Enabled = true;
            }
            catch(SqlException)
            {
                MessageBox.Show("không lấy được nội dung trong database. Lỗi rồi!!");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtthanhpho.Dispose();
            dtthanhpho = null;
            con1 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check = true;
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.panel1.Enabled = true;
            this.label1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            check = false;
            this.panel1.Enabled = true;
            //thứ tự dòng lệnh hiện hành
            int r = dataGridView1.CurrentCell.RowIndex;
            // chuyển thông tin lên panel
            this.textBox1.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.textBox2.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.panel1.Enabled = true;
            // không cho các nút thêm xóa thoát hoạt dộng
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;
            this.textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con1.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con1;
                cmd.CommandType = CommandType.Text;
                int r = dataGridView1.CurrentCell.RowIndex;
                string sthanhpho = dataGridView1.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("delete from thanhPho where thanhpho = '" + sthanhpho + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("đã xóa xong!");
            }
            catch(SqlException)
            {
                MessageBox.Show("không xóa được. lỗi rồi!");
            }
            con1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.panel1.Enabled = false;
            this.button6.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button7.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con1.Open();
            if (check)
            {
                try
                {
                    //thuc hien lenh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con1;
                    cmd.CommandType = CommandType.Text;
                    // thực hiện lệnh insert into
                    cmd.CommandText = System.String.Concat("insert into thanhPho values(" + "N'" + this.textBox1.Text.ToString() + "',N'" + this.textBox2.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // load lai du lieu tren data grid view 
                    loaddata();
                    MessageBox.Show("đã thêm thành công!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("không thêm được rồi!"); 
                }
            }
            if (!check)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con1;
                cmd.CommandType = CommandType.Text;
                // thu tu dong hien hanh
                int r = dataGridView1.CurrentCell.RowIndex;
                string strthanhpho = dataGridView1.Rows[0].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("update thanhPho set tenthanhpho = N'" + this.textBox2.Text.ToString() + "' where thanhpho= N'" + strthanhpho + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("đã sửa xong!");
            } con1.Close();
        }
    }
}
