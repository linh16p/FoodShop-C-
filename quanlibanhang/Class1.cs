using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace quanlibanhang
{
    class connectionstring
    {
        //public static string connect = @"Data Source=LAPTOP-75SKL5D0;Initial Catalog=dangnhap;Integrated Security=True";

        public bool Islol(int a, int b, int c)
        {
            if ((c < 9999 && c > 1000) && (b < 13 && b > 0))
            {
                if (b == 2)
                {
                    if ((c % 400 == 0) || (c % 4 == 0 && c % 100 != 0))
                    {
                        if (a > 0 && a < 30)
                        {
                            /*Console.Write("ngay tiep theo cua ngay {0}/{1}/{2} la: ", a, b, c);
                            if (a == 29) { a = 1; b = b + 1; }
                            else { a = a + 1; }
                            Console.WriteLine(" {0}/{1}/{2}", a, b, c);*/
                            return true;
                        }
                        else return false;
                    }
                    else if (a > 0 && a < 29)
                    {
                        /*Console.Write("ngay tiep theo cua ngay {0}/{1}/{2} la: ", a, b, c);
                        if (a == 28) { a = 1; b = b + 1; }
                        else { a = a + 1; }
                        Console.WriteLine(" {0}/{1}/{2}", a, b, c);*/
                        return true;
                    }
                    else return false;
                }
                else if (b == 1 || b == 3 || b == 5 || b == 7 || b == 8 || b == 10 || b == 12)
                {
                    if (a < 32 && a > 0)
                    {
                        /*Console.Write("ngay tiep theo cua ngay {0}/{1}/{2} la: ", a, b, c);
                        if (a == 31 && b == 12) { a = 1; b = 1; c = c + 1; }
                        else if (a == 31) { a = 1; b = b + 1; }
                        else { a = a + 1; }
                        Console.WriteLine(" {0}/{1}/{2}", a, b, c);*/
                        return true;
                    }
                    else return false;
                }
                else
                {
                    if (a > 0 && a < 31)
                    {
                        /*Console.Write("ngay tiep theo cua ngay {0}/{1}/{2} la: ", a, b, c);
                        if (a == 30) { a = 1; b = b + 1; }
                        else { a = a + 1; }
                        Console.WriteLine(" {0}/{1}/{2}", a, b, c);*/
                        return true;
                    }
                    else return false;
                }
            }
            else return false;
        }

        /* {
         using System;
     using System.Collections.Generic;
     using System.ComponentModel;
     using System.Data;
     using System.Drawing;
     using System.Linq;
     using System.Text;
     using System.Threading.Tasks;
     using System.Windows.Forms;

     namespace WindowsFormsApp4
         {
             public partial class Form1 : Form
             {
                 public Form1()
                 {
                     InitializeComponent();
                 }

                 SinhVien sv = new SinhVien();

                 private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
                 {

                 }

                 private void label1_Click(object sender, EventArgs e)
                 {

                 }

                 private void Form1_Load(object sender, EventArgs e)
                 {
                     dgv.DataSource = sv.GetSV();
                 }

                 private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
                 {

                 }

                 private void label1_Click_1(object sender, EventArgs e)
                 {

                 }

                 private void label8_Click(object sender, EventArgs e)
                 {

                 }

                 private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
                 {

                 }

                 private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
                 {
                     //lay hang dang click: <ten_datagridview>.SelectRows.Count
                     int num = dgv.SelectedRows.Count;

                     //lay du lieu 1 hang trong datagridview
                     DataGridViewRow row = dgv.SelectedRows[0];
                     label9.Text = num.ToString();
                     //
                     txt_msv.Text = row.Cells[0].Value.ToString();
                     txt_hoten.Text = row.Cells[1].Value.ToString();
                     dt_ngaysinh.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());

                     string gioitinh = row.Cells[2].Value.ToString();
                     if (gioitinh == "nam")
                     {
                         btn_nam.Checked = true;
                     }
                     else
                     {
                         btn_nu.Checked = true;
                     }





                 }

                 private void checkBox2_CheckedChanged(object sender, EventArgs e)
                 {

                 }

                 private void button1_Click(object sender, EventArgs e)
                 {
                     sv.MSV = txt_msv.Text;
                     sv.HoTen = txt_hoten.Text;
                     sv.NgaySinh = dt_ngaysinh.Value.ToShortDateString();

                 }
             }
         }
     }{
     using System;
     using System.Collections.Generic;
     using System.Linq;
     using System.Text;
     using System.Threading.Tasks;
     using System.Data;
     using System.Data.SqlClient;


     namespace WindowsFormsApp4
     {
         class SinhVien : DB
         {
             private string msv, hoten, gioitinh, ngaysinh, quequan, lop, khoa;

             public string MSV { get; set; }

             public string HoTen { get; set; }
             public string GioiTinh { get; set; }
             public string NgaySinh { get; set; }
             public string QueQuan { get; set; }
             public string Lop { get; set; }

             public string Khoa { get; set; }
             public DataTable GetSV()
             {
                 DataTable dt = new DataTable();
                 string select = "select * from SINHVIEN";
                 //thuc hien cau truy van voi csdl
                 //new SqlDataAdapter(<chuoi>, <ket noi>)
                 SqlDataAdapter da = new SqlDataAdapter(select, connect);
                 da.Fill(dt);
                 return dt;
             }

             public void AddSV(SinhVien sv)
             {
                 connect.Open();
                 string insert = string.Format();
                 SqlCommand cmd = new SqlCommand();
                 cmd.ExecuteNonQuery();
                 connect.Close();
             }

         }
     }
     }*/
    }
}
