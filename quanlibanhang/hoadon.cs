using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace quanlibanhang
{
    public partial class hoadon : MetroFramework.Forms.MetroForm
    {
        Config conf = Config.getInstance();
        public hoadon()
        {
            InitializeComponent();
            conf.Init();
        }
        private void hoadon_Load(object sender, EventArgs e)
        {
            loaddatasp();
            if (conf.simpleQuery2("select roles from taikhoan where idtk =" + loginSession.IDAcc, 0).Rows[0].Field<bool>("roles").ToString() == "True")
            {
                btQlnv.Visible = true;
            }
            else { btQlnv.Visible = false; }

        }
        void checktab()
        {
            if (tabControl1.SelectedIndex == 1)
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
        private void button1_Click(object sender, EventArgs e)
        {
            if ((tb_ten.Text == "") && (tbmak.Text == "") && (tb_diachi.Text == "") && (tb_sdt.Text == ""))
            {
                MessageBox.Show("bạn đã để trống 1 ô nào đó! vui lòng nhập đủ nhé!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbmak.Focus();
            }
            else
            {
                if (!IsNumber(tb_sdt.Text.ToString()))
                {
                    MessageBox.Show("số điện thoại phải là số!!!");
                    tb_sdt.Focus();
                }
                else
                {
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                }
            }
        }

        void them(int sp, Object soLuong, Object tongTien)
        {
            if (conf.simpleQuery2("select * from khach where makh = " + tbmak.Text.Trim(), 0) == null)
            {
                conf.simpleQuery2("insert into khach values('" + tbmak.Text.Trim() + "', N'" + tb_ten.Text + "', N'" + tb_diachi.Text + "', " + tb_sdt.Text + ")", 1);

                conf.simpleQuery2("insert into hoadon values( '" + tbmak.Text.Trim() + "'," + loginSession.UserID + ",'" + formatDate(dateTimePicker1) + "')", 1);

                conf.simpleQuery2("insert into chitiethoadon values(" + conf.simpleQuery2("select top 1 mahd from hoadon order by mahd desc", 0).Rows[0].Field<int>("mahd").ToString() + ", '" + sp + "', " + soLuong + "," + tongTien + ")", 1);
            }
            else
            {
                conf.simpleQuery2("insert into hoadon values( '" + tbmak.Text.Trim() + "'," + loginSession.UserID + ",'" + formatDate(dateTimePicker1) + "')", 1);

                conf.simpleQuery2("insert into chitiethoadon values(" + conf.simpleQuery2("select top 1 mahd from hoadon order by mahd desc", 0).Rows[0].Field<int>("mahd").ToString() + ", '" + sp + "', " + soLuong + "," + tongTien + ")", 1);
            }
        }
        void sua(string z, Object lb)
        {
            conf.simpleQuery2("update sanpham set soluong ='" + z + "' where tensp = N'" + lb.ToString() + "'", 1);
            loaddatasp();
        }

        void tinhTien(int slmh, int gia, int maMH, int soLuongMua)
        {
            if (slmh > 0)
            {
                if (soLuongMua >= 0 && soLuongMua <= slmh)
                {
                    double discount = conf.simpleQuery2("select khuyenmai from sanpham where masp = '" + maMH + "'", 0).Rows[0].Field<double>("khuyenmai");
                    //MessageBox.Show(discount.ToString());
                    int ga = Convert.ToInt32(gia * soLuongMua * (1 - discount));
                    if (soLuongMua > 0)
                    {
                        them(maMH, soLuongMua, ga);
                        sum += ga;
                        //giam so luong sau do dua tro lai database
                        string n = Convert.ToString(slmh - soLuongMua);
                        switch (maMH)
                        {
                            case 1:
                                sua(n, lbga.Text);
                                if (Convert.ToInt32(dataGridView2.Rows[maMH - 1].Cells[1].Value) < 0)
                                    MessageBox.Show("Hết Gà");
                                break;
                            case 2:
                                sua(n, lbham.Text);
                                if (Convert.ToInt32(dataGridView2.Rows[maMH - 1].Cells[1].Value) < 0)
                                    MessageBox.Show("Hết hamburger ");
                                break;
                            case 3:
                                sua(n, lbdon.Text);
                                if (Convert.ToInt32(dataGridView2.Rows[maMH - 1].Cells[1].Value) < 0)
                                    MessageBox.Show("Hết hamburger ");
                                break;
                        }
                    }
                }
                else
                {
                    switch (maMH)
                    {
                        case 1:
                            MessageBox.Show("Không Đủ Gà", "Thông Báo!");
                            break;
                        case 2:
                            MessageBox.Show("Không Đủ hamburger", "Thông Báo!");
                            break;
                        case 3:
                            MessageBox.Show("Không Đủ doney keybap", "Thông Báo!");
                            break;
                    }
                }
            }
            else if (soLuongMua > 0)
            {
                switch (maMH)
                {
                    case 1:
                        MessageBox.Show("Hết Gà", "Thông Báo!");
                        break;
                    case 2:
                        MessageBox.Show("Hết hamburger", "Thông Báo!");
                        break;
                    case 3:
                        MessageBox.Show("Hết doney keybap", "Thông Báo!");
                        break;
                }
            }
        }

        int sum;
        private void button2_Click(object sender, EventArgs e)
        {
            tb_tongtien.Clear();
            sum = 0;
            int slg = Convert.ToInt32(dataGridView2.Rows[0].Cells[1].Value);
            int slh = Convert.ToInt32(dataGridView2.Rows[1].Cells[1].Value);
            int sld = Convert.ToInt32(dataGridView2.Rows[2].Cells[1].Value);

            tinhTien(slg, 28000, 1, Convert.ToInt32(numericUpDown1.Value));
            tinhTien(slh, 30000, 2, Convert.ToInt32(numericUpDown2.Value));
            tinhTien(sld, 20000, 3, Convert.ToInt32(numericUpDown3.Value));

            tb_tongtien.Text = Convert.ToString(sum);
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            dataGridView1.DataSource = conf.simpleQuery2("select DISTINCT khach.hotenkh, khach.diachi, khach.dienthoai, hoadon.ngaynhap, sanpham.tensp, chitiethoadon.soluongmua, chitiethoadon.tongtien from hoadon,chitiethoadon,sanpham,khach where hoadon.mahd = chitiethoadon.mahd AND hoadon.makh = khach.makh AND chitiethoadon.masp = sanpham.masp", 0);
        }
        void loaddatasp()
        {
            try
            {
                dataGridView2.DataSource = conf.simpleQuery2("select tensp,soluong from sanpham", 0);
                tb_ga.ResetText();
                tb_ham.ResetText();
                tb_don.ResetText();
            }
            catch (SqlException)
            {
                MessageBox.Show("khong lay duoc du lieu!!");
            }
        }
        void do_v(int sl, Object tenSp)
        {
            conf.simpleQuery2("update sanpham set soluong ='" + sl + "' where tensp = N'" + tenSp.ToString() + "'", 1);
            loaddatasp();
            MessageBox.Show("them " + tenSp.ToString() + " thanh cong!!");
        }

        void nhapKho(string sl, int row, string tenSp)
        {
            if (sl != "" && IsNumber(sl))
            {
                if (Convert.ToInt32(sl) > 0)
                {
                    int r = Convert.ToInt32(dataGridView2.Rows[row].Cells[1].Value);
                    int c = r + Convert.ToInt32(sl);
                    do_v(c, tenSp);
                }
                else { MessageBox.Show("Vui lòng nhập lại hộ mị nhé bé ơi!"); }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string s1 = tb_ga.Text;
            string s2 = tb_ham.Text;
            string s3 = tb_don.Text;

            nhapKho(s1, 0, lbga.Text);
            nhapKho(s2, 1, lbham.Text);
            nhapKho(s3, 2, lbdon.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbmak.ResetText();
            tb_ten.ResetText();
            tb_diachi.ResetText();
            tb_sdt.ResetText();
            tb_tongtien.ResetText();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void hoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btreload_Click(object sender, EventArgs e)
        {
            loaddatasp();
            this.button4.Enabled = true;
        }

        public string formatDate(DateTimePicker dt)
        {
            return dt.Value.Year.ToString() + "-" + dt.Value.Month.ToString() + "-" + dt.Value.Day.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (rbkhoang.Checked == true)
            {
                dataGridView3.DataSource = conf.simpleQuery2("select DISTINCT khach.hotenkh, khach.diachi, khach.dienthoai, hoadon.ngaynhap, sanpham.tensp, chitiethoadon.soluongmua, chitiethoadon.tongtien from hoadon,chitiethoadon,sanpham,khach where hoadon.mahd = chitiethoadon.mahd AND hoadon.makh = khach.makh AND chitiethoadon.masp = sanpham.masp and ngaynhap between '" + formatDate(dtpBatDau) + "' and '" + formatDate(dtpKetThuc) + "'", 0);
            }
            else if (rbNam.Checked == true)
            {
                dataGridView3.DataSource = conf.simpleQuery2("select DISTINCT khach.hotenkh, khach.diachi, khach.dienthoai, hoadon.ngaynhap, sanpham.tensp, chitiethoadon.soluongmua, chitiethoadon.tongtien from hoadon,chitiethoadon,sanpham,khach where hoadon.mahd = chitiethoadon.mahd AND hoadon.makh = khach.makh AND chitiethoadon.masp = sanpham.masp and YEAR(ngaynhap) = " + dtpNam.Text, 0);
            }
            else if (rbmathang.Checked == true)
            {
                if (cbmon.SelectedItem != null)
                {
                    dataGridView3.DataSource = conf.simpleQuery2("select sanpham.tensp, SUM(chitiethoadon.soluongmua) as soluongdaban, SUM(chitiethoadon.tongtien) as tongtien from sanpham, chitiethoadon where sanpham.masp = chitiethoadon.masp and tensp = N'" + cbmon.SelectedItem.ToString() + "' group by sanpham.tensp", 0);
                }
                else
                {
                    MessageBox.Show("hãy chọn một món!");
                    cbmon.Focus();
                }
            }
            else if (rbthang.Checked == true)
            {
                if (cbthang_thongke.SelectedItem != null)
                {
                    dataGridView3.DataSource = conf.simpleQuery2("select DISTINCT khach.hotenkh, khach.diachi, khach.dienthoai, hoadon.ngaynhap, sanpham.tensp, chitiethoadon.soluongmua, chitiethoadon.tongtien from hoadon,chitiethoadon,sanpham,khach where hoadon.mahd = chitiethoadon.mahd AND hoadon.makh = khach.makh AND chitiethoadon.masp = sanpham.masp and MONTH(ngaynhap) = " + cbthang_thongke.SelectedItem.ToString(), 0);
                }
                else
                {
                    MessageBox.Show("hãy chọn một tháng cụ thể!");
                    cbthang_thongke.Focus();
                }
            }
            else if (rbKhach.Checked == true)
            {
                dataGridView3.DataSource = conf.simpleQuery2("select khach.hotenkh, sum(chitiethoadon.soluongmua) as soluongmua, sum(chitiethoadon.tongtien) as tongtien from khach, hoadon, chitiethoadon where khach.makh = hoadon.makh and hoadon.mahd = chitiethoadon.mahd group by khach.hotenkh", 0);
            }
            else if (rbNhanvien.Checked == true)
            {

                dataGridView3.DataSource = conf.simpleQuery2("select nhanvien.idnv,nhanvien.tennv,sdt,diachi,email,trangthai,sum(soluongmua) as soluongban, sum(tongtien) as doanhthu from nhanvien, hoadon, chitiethoadon, sanpham where nhanvien.idnv = hoadon.idnv and hoadon.mahd = chitiethoadon.mahd and chitiethoadon.masp = sanpham.masp group by nhanvien.idnv,nhanvien.tennv,sdt,diachi,email,trangthai", 0);
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form3();
            frm.ShowDialog();
            this.Close();
        }

        private void tbmak_TextChanged(object sender, EventArgs e)
        {
            if (tbmak.Text != "" && conf.simpleQuery2("select * from khach where makh = " + tbmak.Text.Trim(), 0) != null)
            {
                tb_ten.Text = conf.simpleQuery2("select * from khach where makh = " + tbmak.Text.Trim(), 0).Rows[0].Field<string>("hotenkh");
                tb_diachi.Text = conf.simpleQuery2("select * from khach where makh = " + tbmak.Text.Trim(), 0).Rows[0].Field<string>("diachi");
                tb_sdt.Text = conf.simpleQuery2("select * from khach where makh = " + tbmak.Text.Trim(), 0).Rows[0].Field<double>("dienthoai").ToString();
            }
            else
            {
                tb_ten.ResetText();
                tb_diachi.ResetText();
                tb_sdt.ResetText();
                tb_tongtien.ResetText();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.ShowDialog();
        }
    }
}
