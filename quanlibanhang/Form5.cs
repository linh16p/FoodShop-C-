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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string ketnoi = " Data Source =LAPTOP-75SKL5D0; Initial Catalog=qlbanhang; Integrated Security = True";
        SqlConnection conn = null;
        SqlDataAdapter datable = null;
        DataTable dttable = null;
        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi động connection
                conn = new SqlConnection(ketnoi);
                // Xử lý danh mục
                int danhmuc = Convert.ToInt32(this.Text);
                switch (danhmuc)
                {
                    case 1:
                        label1.Text = "Danh mục thành phố";
                        datable = new SqlDataAdapter("select thanhpho, tenthanhpho from thanhPho", conn);
                        break;
                    case 2:
                        label1.Text = "Danh mục khách hàng";
                        datable = new SqlDataAdapter("select makh, tencty from khachhang", conn);
                        break;
                    case 3:
                        label1.Text = "Danh mục nhân viên";
                        datable = new SqlDataAdapter("select manv,ho,ten from nhanvien", conn);
                        break;
                    case 4:
                        label1.Text = "Danh mục sản phẩm ";
                        datable = new SqlDataAdapter("select masp, tensp,donvitinh, dongia from sanpham ", conn);
                        break;
                    case 5:
                        label1.Text = "Danh mục hóa đơn";
                        datable = new SqlDataAdapter("select mahd, makh,manv,ngaylaphd,ngaynhanhang from hoadon", conn);
                        break;
                    case 6:
                        label1.Text = "Danh mục chi tiết hóa đơn";
                        datable = new SqlDataAdapter("select * from chitiethoadon", conn);
                        break;
                    default:
                        break;
                }
                // vận chuyển dữ liệu lên trên Datable dttable
                dttable = new DataTable();
                dttable.Clear();
                datable.Fill(dttable);
                // dua du lieu len datagridview
                dataGridView1.DataSource = dttable;
                // thay doi do rong cot
                dataGridView1.AutoResizeColumns();

            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table.Lỗi rồi!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            dttable.Dispose();
            dttable = null;
            conn = null;
        }
    }
    
}
