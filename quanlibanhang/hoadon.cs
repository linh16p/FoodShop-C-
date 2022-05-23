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
    public partial class hoadon : Form
    {
        public hoadon()
        {
            InitializeComponent();
        }
        //string strcon = "Data Source=LAPTOP-75SKL5D0;Initial Catalog=bandoannhanh;Integrated Security=True";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-853MUV6;Initial Catalog=bandoannhanh;Integrated Security=True");
        SqlDataAdapter dakhach = null;
        DataTable dtkhach = null;
        SqlDataAdapter dasanpham = null;
        DataTable dtsanpham = null;
        private void hoadon_Load(object sender, EventArgs e)
        {
            loaddatasp();
            //checktab();
        }
        void checktab()
        {
            if(tabControl1.SelectedIndex == 1)
            {
                this.button4.Enabled = false;
                loaddatasp();
            }
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
        public bool Islol(int a, int b, int c)
        {
                if (b == 2)
                {
                if ((c % 400 == 0) || (c % 4 == 0 && c % 100 != 0))
                {
                    if (a > 0 && a < 30)
                    {
                        return true;
                    }
                    else { MessageBox.Show("tháng này chỉ có 29 ngày thôi, năm nhuận mà :))"); return false; }
                }
                else if (a > 0 && a < 29)
                {
                    return true;
                }
                else { MessageBox.Show("tháng này chỉ có 28 ngày thôi"); return false;  }
                }
                else if (b == 1 || b == 3 || b == 5 || b == 7 || b == 8 || b == 10 || b == 12)
                {
                    if (a < 32 && a > 0)
                    {
                        return true;
                    }
                    else return false;
                }
                else
                {
                    if (a > 0 && a < 31)
                    {
                        return true;
                    }
                    else { MessageBox.Show("tháng này chỉ có 30 ngày thôi"); return false; }
            }
        }
        void dtc()
        {
            int d = Convert.ToInt32(cb_ngay.SelectedItem);
            int t = Convert.ToInt32(cb_thang.SelectedItem);
            int n = Convert.ToInt32(mtb_nam.Text);
            if (!IsNumber(tb_sdt.Text.ToString()))
            {
                MessageBox.Show("số điện thoại phải là số!!!");
                tb_sdt.Focus();
            }
            else if (!Islol(d,t,n))
            {
                MessageBox.Show("ngày tháng bị sai!!!");
                cb_ngay.SelectedIndex = -1;
                cb_thang.SelectedIndex = -1;
                mtb_nam.ResetText();
            }
            else {
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((tb_ten.Text !="") && (tbmak.Text !="" )&& (tb_diachi.Text != "" )&& (tb_sdt.Text != "") && (cb_ngay.SelectedItem != null) && (cb_thang.SelectedItem != null) && (mtb_nam.Text != ""))
            {
                //conn = new SqlConnection(strcon);
                dtc();
                
            }
            else
            {
                MessageBox.Show("bạn đã để trống 1 ô nào đó! vui lòng nhập đủ nhé!","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbmak.Focus();
            }
            /*conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("",conn);*/
        }
        void loadkhach()
        {
            //conn.Open();
            try
            {
                dakhach = new SqlDataAdapter("select * from khach",conn);
                dtkhach = new DataTable();
                dtkhach.Clear();
                dakhach.Fill(dtkhach);
                dataGridView1.DataSource = dtkhach;
            }
            catch (SqlException)
            {
                MessageBox.Show("khong lay dc du lieu");
            }
            //conn.Close();
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        void them(Object a, Object b, Object m, Object d, Object e, Object f, Object g, Object h, Object i, Object j)
        {
            conn.Open();
            /*try
            {
                */
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = System.String.Concat("insert into khach values('" + a.ToString() + "',N'" + b.ToString() + "',N'" + m.ToString() + "','" + d.ToString() + "','" + e.ToString() + "','" +f.ToString() + "','" + g.ToString() + "','" + h.ToString() + "','" + i.ToString() + "','" + j + "')");
                cmd2.CommandType = CommandType.Text;
                cmd2.ExecuteNonQuery();
                loadkhach();
                
                MessageBox.Show("mot ban ghi da dc them!");
            /*}
            catch (SqlException)
            {
                MessageBox.Show("ko lay duoc du lieu!(them)");
            }*/
            conn.Close();
        }
        void sua(string z,Object lb)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = System.String.Concat("update sanpham set soluong ='" + z + "' where tensp = N'"+lb.ToString()+"'");
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
            loaddatasp();
            conn.Close();
        }
        int sum ;
        private void button2_Click(object sender, EventArgs e)
        {
            tb_tongtien.Clear();
            sum = 0;
            int slg = Convert.ToInt32(dataGridView2.Rows[1].Cells[1].Value);
            int slh = Convert.ToInt32(dataGridView2.Rows[2].Cells[1].Value);
            int sld = Convert.ToInt32(dataGridView2.Rows[0].Cells[1].Value);
            if (slg > 0)
            {
                int g = 28000;
                int ga;
                //int s = 0;

                if (numericUpDown1.Value >= 0 && numericUpDown1.Value <= slg)
                {
                    ga = Convert.ToInt32(g * numericUpDown1.Value);
                    if (numericUpDown1.Value > 0)
                    { 
                        them(tbmak.Text, tb_ten.Text, tb_diachi.Text, tb_sdt.Text, cb_ngay.SelectedItem, cb_thang.SelectedItem, mtb_nam.Text, lbga.Text, numericUpDown1.Value, ga);
                    }
                    sum += ga;

                    //giam so luong sau do dua tro lai database
                    string n = Convert.ToString(slg - numericUpDown1.Value);
                    
                    sua(n, lbga.Text);
                    if (Convert.ToInt32(dataGridView2.Rows[1].Cells[1].Value) < 0)
                    {
                        MessageBox.Show("Hết Gà");
                        tb_ga.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Không Đủ Gà", "Thông Báo!");
                }
                //tb_tongtien.Text = Convert.ToString(sum);
            }
            else if (numericUpDown1.Value > 0)
                MessageBox.Show("Hết Gà");
            if (slh > 0)
            {
                int h = 30000;
                int ha;
                //int si = 0;
                if (numericUpDown2.Value >= 0 && numericUpDown2.Value <= slh)
                {
                    ha = Convert.ToInt32(h * numericUpDown2.Value);
                    if (numericUpDown2.Value > 0)
                    {
                        //dataGridView1.Rows.Add("hamburger", "30000", numericUpDown2.Value, ha);
                        them(tbmak.Text, tb_ten.Text, tb_diachi.Text, tb_sdt.Text, cb_ngay.SelectedItem, cb_thang.SelectedItem, mtb_nam.Text, lbham.Text, numericUpDown2.Value, ha);
                    }

                    sum += ha;
                    //si = Convert.ToInt32(tb_ham.Text);
                    string n1 = Convert.ToString(slh - numericUpDown2.Value);
                    sua(n1, lbham.Text);
                    if (Convert.ToInt32(dataGridView2.Rows[2].Cells[1].Value) < 0)
                    {
                        MessageBox.Show("Hết hamburger ");
                        tb_ham.Text = "0";
                    }
                    //tb_tongtien.Text = Convert.ToString(sum);
                }
                else
                {
                    MessageBox.Show("Không Đủ hamburger", "Thông Báo!");
                }
            }
            else if (numericUpDown2.Value > 0)
            {
                MessageBox.Show("Hết hamburger", "Thông Báo!");
            }
            
            if (sld > 0)
            {
                int k = 20000;
                int ke;
                //int sim = 0;
                if (numericUpDown3.Value >= 0 && numericUpDown3.Value <= sld)
                {
                    ke = Convert.ToInt32(k * numericUpDown3.Value);
                    if (numericUpDown3.Value > 0)
                    {
                        them(tbmak.Text, tb_ten.Text, tb_diachi.Text, tb_sdt.Text, cb_ngay.SelectedItem, cb_thang.SelectedItem, mtb_nam.Text, lbdon.Text, numericUpDown3.Value, ke);
                    }
                    //dataGridView1.Rows.Add("doney keybap", "20000", numericUpDown3.Value, ke);ddd55454 }
                    sum += ke;
                    //sim = Convert.ToInt32(tb_don.Text);
                    string n2 = Convert.ToString(sld - numericUpDown3.Value);
                    sua(n2, lbdon.Text);
                    if (Convert.ToInt32(dataGridView2.Rows[0].Cells[1].Value) < 0)
                    {
                        MessageBox.Show("Hết doney keybap ");
                        tb_don.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Không Đủ doney keybap");
                }
                    tb_tongtien.Text = Convert.ToString(sum);
            }
            else if (numericUpDown3.Value > 0)
            {
                 MessageBox.Show("Hết doney keybap", "Thông Báo!");
            }
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
            
        }
         void loaddatasp()
        {
            try
            {
                //conn.Open();
                dasanpham = new SqlDataAdapter("select tensp,soluong from sanpham", conn);
                dtsanpham = new DataTable();
                dtsanpham.Clear();
                dasanpham.Fill(dtsanpham);
                dataGridView2.DataSource = dtsanpham;
                tb_ga.ResetText();
                tb_ham.ResetText();
                tb_don.ResetText();
            }
            catch (SqlException)
            {
                MessageBox.Show("khong lay duoc du lieu!!");
            }
        }
        void do_v(int s, Object ll)
        {
           /* try
            {*/
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = System.String.Concat("update sanpham set soluong ='" + s + "' where tensp = N'"+ll.ToString()+"'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loaddatasp();
                string v =  "them "+ll.ToString() +" thanh cong!!";
                MessageBox.Show(v);
                conn.Close();
            /*}
            catch (SqlException)
            {
                MessageBox.Show("them ga that bai!!");
            }*/
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string s1 = tb_ga.Text;
            string s2 = tb_ham.Text;
            string s3 = tb_don.Text;
            /*int r = Convert.ToInt32(dataGridView2.Rows[1].Cells[1].Value);
            int c = r + Convert.ToInt32(s1);
            int r1 = Convert.ToInt32(dataGridView2.Rows[2].Cells[1].Value);
            int c1 = r1 + Convert.ToInt32(s2);
            int r2 = Convert.ToInt32(dataGridView2.Rows[0].Cells[1].Value);
            int c2 = r2 + Convert.ToInt32(s3);*/
            if (s1 != "" && IsNumber(s1))
            {
                if (Convert.ToInt32(s1) > 0)
                {
                    int r = Convert.ToInt32(dataGridView2.Rows[1].Cells[1].Value);
                    int c = r + Convert.ToInt32(s1);
                    do_v(c, lbga.Text);
                }
                else if (Convert.ToInt32(s1) < 0) { MessageBox.Show("không được nhập số âm!!!"); }
            }
            if (s2 != "" && IsNumber(s2))
            {
                if (Convert.ToInt32(s2) > 0)
                {
                    int r1 = Convert.ToInt32(dataGridView2.Rows[2].Cells[1].Value);
                    int c1 = r1 + Convert.ToInt32(s2);
                    do_v(c1, lbham.Text);
                }
            }
            if (s3 != "" && IsNumber(s3))
            {
                if (Convert.ToInt32(s3) > 0)
                {
                    int r2 = Convert.ToInt32(dataGridView2.Rows[0].Cells[1].Value);
                    int c2 = r2 + Convert.ToInt32(s3); 
                    do_v(c2, lbdon.Text);
                }
            }
            /*int c, c1, c2,r,r1,r2;
            if (tb_ga.Text != "" && Convert.ToInt32(tb_ga.Text) > 0)
            {
                 r = Convert.ToInt32(dataGridView2.Rows[1].Cells[1].Value);
                 c = r + Convert.ToInt32(tb_ga.Text);
            }
            //else if(tb_ga.Text != "" && Convert.ToInt32(tb_ga.Text)<0) { MessageBox.Show("không được nhập số âm!!!"); }

            if (tb_ham.Text != "" && Convert.ToInt32(tb_ham.Text) > 0)
            {
                r1 = Convert.ToInt32(dataGridView2.Rows[2].Cells[1].Value);
                c1 = r1 + Convert.ToInt32(tb_ham.Text);

            }
            if (tb_don.Text != "" && Convert.ToInt32(tb_don.Text) > 0)
            {
                r2 = Convert.ToInt32(dataGridView2.Rows[0].Cells[1].Value);
                c2 = r2 + Convert.ToInt32(tb_don.Text);
            }*/
            /*int r = Convert.ToInt32(dataGridView2.Rows[1].Cells[1].Value);
            int c = r + Convert.ToInt32(tb_ga.Text);
            int r1 = Convert.ToInt32(dataGridView2.Rows[2].Cells[1].Value);
            int c1 = r1 + Convert.ToInt32(tb_ham.Text);
            int r2 = Convert.ToInt32(dataGridView2.Rows[0].Cells[1].Value);
            int c2 = r2 + Convert.ToInt32(tb_don.Text);*/
            /*if ((tb_ga.Text != "" && Convert.ToInt32(tb_ga.Text) > 0) && (tb_ham.Text != "" && Convert.ToInt32(tb_ham.Text) > 0) && (tb_don.Text != "" && Convert.ToInt32(tb_don.Text) > 0))
            {
                do_v(c, lbga.Text); do_v(c1, lbham.Text); do_v(c2, lbdon.Text);
            }
            else if ((tb_ga.Text != "" && Convert.ToInt32(tb_ga.Text) > 0) && (tb_ham.Text != "" && Convert.ToInt32(tb_ham.Text) > 0)) { do_v(c, lbga.Text); do_v(c1, lbham.Text); }
            else if ((tb_ham.Text != "" && Convert.ToInt32(tb_ham.Text) > 0) && (tb_don.Text != "" && Convert.ToInt32(tb_don.Text) > 0)) { do_v(c1, lbham.Text); do_v(c2, lbdon.Text); }
            else if ((tb_ga.Text != "" && Convert.ToInt32(tb_ga.Text) > 0) && (tb_don.Text != "" && Convert.ToInt32(tb_don.Text) > 0)) { do_v(c, lbga.Text); do_v(c2, lbdon.Text); }*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbmak.ResetText();
            tb_ten.ResetText();
            tb_diachi.ResetText();
            tb_sdt.ResetText();
            tb_tongtien.ResetText();
            //cb_ngay.ResetText();
            cb_ngay.SelectedIndex = -1;
            //cb_thang.ResetText();
            cb_thang.SelectedIndex = -1;
            mtb_nam.ResetText();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void hoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dtsanpham != null)
            {
                dtsanpham.Dispose();
                dtsanpham = null;
            }
            if (dtkhach != null)
            {
                dtkhach.Dispose();
                dtkhach = null;
            }
            conn = null;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void btreload_Click(object sender, EventArgs e)
        {

            loaddatasp();
            this.button4.Enabled = true;
            //tb_don.Text = dataGridView2.Rows[1].Cells[1].Value.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //checktab();
        }
        void check(Object cb)
        {
            try
            {
                conn.Open();
                dakhach = new SqlDataAdapter("select * from khach where tensp =N'" + cb.ToString() + "' ", conn);
                dtkhach = new DataTable();
                dtkhach.Clear();
                dakhach.Fill(dtkhach);
                //loadkhach();
                dataGridView3.DataSource = dtkhach;
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("không lấy được dữ liệu!!");
            }
        }
        void check(Object cb, Object cb1)
        {
            try
            {
                conn.Open();
                dakhach = new SqlDataAdapter("select * from khach where tensp =N'" + cb.ToString() + "' and thang='"+cb1.ToString()+"' ", conn);
                dtkhach = new DataTable();
                dtkhach.Clear();
                dakhach.Fill(dtkhach);
                //loadkhach();
                dataGridView3.DataSource = dtkhach;
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("không lấy được dữ liệu!!");
            }
        }

        void check(Object cb, Object cb1,Object cb2)
        {
            try
            {
                conn.Open();
                dakhach = new SqlDataAdapter("select * from khach where tensp =N'" + cb.ToString() + "' and thang='" + cb1.ToString() + "' and ngay = '"+cb2.ToString()+"' ", conn);
                dtkhach = new DataTable();
                dtkhach.Clear();
                dakhach.Fill(dtkhach);
                //loadkhach();
                dataGridView3.DataSource = dtkhach;
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("không lấy được dữ liệu!!");
            }
        }
        void check(Object cb, Object cb1, Object cb2,Object cb3)
        {
            try
            {
                conn.Open();
                dakhach = new SqlDataAdapter("select * from khach where tensp =N'" + cb.ToString() + "' and thang='" + cb1.ToString() + "' and ngay = '" + cb2.ToString() + "' and nam ='"+cb3.ToString()+"' ", conn);
                dtkhach = new DataTable();
                dtkhach.Clear();
                dakhach.Fill(dtkhach);
                //loadkhach();
                dataGridView3.DataSource = dtkhach;
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("không lấy được dữ liệu!!");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(chbmon.Checked == true && chbthang.Checked == true)
            {
                if (cbmon.SelectedItem != null && cbthang_thongke.SelectedItem != null)
                { 
                    check(cbmon.SelectedItem, cbthang_thongke.SelectedItem);
                    return;
                }
                else
                {
                    MessageBox.Show("hãy chọn món và tháng cụ thể!");
                    cbmon.Focus();
                }
            }
            else if(chbmon.Checked == true)
            {
                if(cbmon.SelectedItem != null)
                {
                    check(cbmon.SelectedItem);
                }
                else
                {
                    MessageBox.Show("hãy chọn một món!");
                    cbmon.Focus();
                }
            }
            else if (chbthang.Checked == true)
            {
                if (cbthang_thongke.SelectedItem != null)
                {
                    check(cbthang_thongke.SelectedItem);
                }
                else
                {
                    MessageBox.Show("hãy chọn một tháng cụ thể!");
                    cbthang_thongke.Focus();
                }
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm5 = new quenmk();
            frm5.Text = "ĐỔI MẬT KHẨU";
            frm5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm5 = new createacc();

            frm5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form3();
            frm.ShowDialog();
            this.Close();
        }

        private void chbmon_CheckedChanged(object sender, EventArgs e)
        {
            if(this.chbmon.Checked == false)
            {
                cbmon.SelectedIndex = -1;
            }
        }

        private void chbthang_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbthang.Checked == false)
            {
                cbthang_thongke.SelectedIndex = -1;
            }
        }
        void change()
        {
            conn.Open();
            //loadkhach();
            dakhach = new SqlDataAdapter("select tenkh,diachi,sodienthoai,ngay,thang,nam from khach where makh ='" + tbmak.Text.ToString() + "'", conn);
            dtkhach = new DataTable();
            dtkhach.Clear();
            dakhach.Fill(dtkhach);
            DataRow dr = dtkhach.Rows[0];
            tb_ten.Text = dr["tenkh"].ToString();
            tb_diachi.Text = dr["diachi"].ToString();
            tb_sdt.Text = dr["sodienthoai"].ToString();
            //tb_sdt.Text = dr["tenkh"].ToString();
            /*cb_ngay.SelectedItem = dr["ngay"].ToString();
            cb_thang.SelectedItem = dr["thang"].ToString();
            mtb_nam.Text = dr["nam"].ToString();*/
            /*dataGridView1.DataSource = dtkhach;
            int r = dataGridView1.CurrentCell.RowIndex;
            tb_ten.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            tb_diachi.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            tb_sdt.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            cb_ngay.SelectedItem = dataGridView1.Rows[r].Cells[4].Value.ToString();
            cb_thang.SelectedItem = dataGridView1.Rows[r].Cells[5].Value.ToString();
            mtb_nam.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();*/
            conn.Close();
        }
        //bool c;
        bool k()
        {
                conn.Open();
                SqlCommand cmd9 = new SqlCommand("select makh,tenkh,diachi,sodienthoai,ngay,thang,nam from khach where makh ='" + tbmak.Text.ToString() + "'", conn);
                SqlDataReader dtr = cmd9.ExecuteReader();
                if (dtr.Read() == true)
                {
                    conn.Close();
                    return true;
                    //change();
                }
                else { conn.Close(); return false; }
                //conn.Close();
        }
        void check2()
        {
            conn.Open();
            SqlCommand cmd9 = new SqlCommand("select makh,tenkh,diachi,sodienthoai,ngay,thang,nam from khach where makh ='"+tbmak.Text.ToString()+"'",conn);
            SqlDataReader dtr = cmd9.ExecuteReader();
            if (dtr.Read() == true)
            {
                conn.Close();
                //c = true;
                change();
            }
            //else { c = false; }
            conn.Close();
        }
        private void tbmak_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check2();
        }

        private void tbmak_TextChanged(object sender, EventArgs e)
        {
            if(tbmak.Text!="" && k())
                check2();
            else
            {
                tb_ten.ResetText();
                tb_diachi.ResetText();
                tb_sdt.ResetText();
                tb_tongtien.ResetText();
                //cb_ngay.ResetText();
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
