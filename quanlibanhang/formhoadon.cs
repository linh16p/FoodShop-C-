using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlibanhang
{
    public partial class formhoadon : MetroFramework.Forms.MetroForm
    {
        Config conf = Config.getInstance();
        public formhoadon()
        {
            InitializeComponent();
        }

        private void formhoadon_Load(object sender, EventArgs e)
        {
            loaddatasp();
            metroGridHoaDon.DataSource = conf.simpleQuery2("select DISTINCT khach.hotenkh, khach.diachi, khach.dienthoai, hoadon.ngaynhap,idnv, sanpham.tensp, chitiethoadon.soluongmua, chitiethoadon.tongtien from hoadon,chitiethoadon,sanpham,khach where hoadon.mahd = chitiethoadon.mahd AND hoadon.makh = khach.makh AND chitiethoadon.masp = sanpham.masp", 0);
            if (conf.simpleQuery2("select roles from taikhoan where idtk =" + loginSession.IDAcc, 0).Rows[0].Field<bool>("roles").ToString() == "True")
            {
                metroBtQuanLiNhanVien.Visible = true;
            }
            else { metroBtQuanLiNhanVien.Visible = false; }
        }

        void loaddatasp()
        {
            try
            {
                metroGridNhapKho.DataSource = conf.simpleQuery2("select tensp,soluong from sanpham", 0);
                metroTbNhapGa.ResetText();
                metroTbHam.ResetText();
                metroTbDon.ResetText();
            }
            catch (SqlException)
            {
                MessageBox.Show("khong lay duoc du lieu!!");
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

        public string formatDate(MetroDateTime dt)
        {
            return dt.Value.Year.ToString() + "-" + dt.Value.Month.ToString() + "-" + dt.Value.Day.ToString();
        }

        private void metroBtChonMon_Click(object sender, EventArgs e)
        {
            if ((metroTbTenKhach.Text == "") && (metroTbMaKhach.Text == "") && (metroTbDiaChi.Text == "") && (metroTbSdt.Text == ""))
            {
                MessageBox.Show("bạn đã để trống 1 ô nào đó! vui lòng nhập đủ nhé!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroTbMaKhach.Focus();
            }
            else
            {
                if (!IsNumber(metroTbSdt.Text))
                {
                    MessageBox.Show("số điện thoại phải là số!!!");
                    metroTbSdt.Focus();
                }
                else
                {
                    metroPanelThongTinKhach.Enabled = false;
                    metroPanelMenu.Enabled = true;
                }
            }
        }

        void them(int sp, Object soLuong, Object tongTien)
        {
            if (conf.simpleQuery2("select * from khach where makh = " + metroTbMaKhach.Text.Trim(), 0) == null)
            {
                conf.simpleQuery2("insert into khach values('" + metroTbMaKhach.Text.Trim() + "', N'" + metroTbTenKhach.Text + "', N'" + metroTbDiaChi.Text + "', " + metroTbSdt.Text + ")", 1);

                conf.simpleQuery2("insert into hoadon values( '" + metroTbMaKhach.Text.Trim() + "'," + loginSession.UserID + ",'" + formatDate(metroDateTimeNgay) + "')", 1);

                conf.simpleQuery2("insert into chitiethoadon values(" + conf.simpleQuery2("select top 1 mahd from hoadon order by mahd desc", 0).Rows[0].Field<int>("mahd").ToString() + ", '" + sp + "', " + soLuong + "," + tongTien + ")", 1);
            }
            else
            {
                conf.simpleQuery2("insert into hoadon values( '" + metroTbMaKhach.Text.Trim() + "'," + loginSession.UserID + ",'" + formatDate(metroDateTimeNgay) + "')", 1);

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
                                sua(n, metroLbGa.Text);
                                if (Convert.ToInt32(metroGridNhapKho.Rows[maMH - 1].Cells[1].Value) < 0)
                                    MessageBox.Show("Hết Gà");
                                break;
                            case 2:
                                sua(n, metroLbHam.Text);
                                if (Convert.ToInt32(metroGridNhapKho.Rows[maMH - 1].Cells[1].Value) < 0)
                                    MessageBox.Show("Hết hamburger ");
                                break;
                            case 3:
                                sua(n, metroLbDon.Text);
                                if (Convert.ToInt32(metroGridNhapKho.Rows[maMH - 1].Cells[1].Value) < 0)
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

        private void metroBtTinh_Click(object sender, EventArgs e)
        {
            metroTbTongTien.Clear();
            sum = 0;
            int slg = Convert.ToInt32(metroGridNhapKho.Rows[0].Cells[1].Value);
            int slh = Convert.ToInt32(metroGridNhapKho.Rows[1].Cells[1].Value);
            int sld = Convert.ToInt32(metroGridNhapKho.Rows[2].Cells[1].Value);

            tinhTien(slg, 28000, 1, Convert.ToInt32(numericUpDownGa.Value));
            tinhTien(slh, 30000, 2, Convert.ToInt32(numericUpDownHam.Value));
            tinhTien(sld, 20000, 3, Convert.ToInt32(numericUpDownDon.Value));

            metroTbTongTien.Text = Convert.ToString(sum);
            numericUpDownGa.Value = 0;
            numericUpDownHam.Value = 0;
            numericUpDownDon.Value = 0;
            metroGridHoaDon.DataSource = conf.simpleQuery2("select DISTINCT khach.hotenkh, khach.diachi, khach.dienthoai, hoadon.ngaynhap,idnv,sanpham.tensp, chitiethoadon.soluongmua, chitiethoadon.tongtien from hoadon,chitiethoadon,sanpham,khach where hoadon.mahd = chitiethoadon.mahd AND hoadon.makh = khach.makh AND chitiethoadon.masp = sanpham.masp", 0);

        }

        private void metroBtNext_Click(object sender, EventArgs e)
        {
            metroTbMaKhach.ResetText();
            metroTbTenKhach.ResetText();
            metroTbDiaChi.ResetText();
            metroTbSdt.ResetText();
            metroTbTongTien.ResetText();
            numericUpDownGa.Value = 0;
            numericUpDownHam.Value = 0;
            numericUpDownDon.Value = 0;
            metroPanelThongTinKhach.Enabled = true;
            metroPanelMenu.Enabled = false;
        }

        private void metroBtBack_Click(object sender, EventArgs e)
        {
            numericUpDownGa.Value = 0;
            numericUpDownHam.Value = 0;
            numericUpDownDon.Value = 0;
            metroPanelThongTinKhach.Enabled = true;
            metroPanelMenu.Enabled = false;
        }

        private void metroTbMaKhach_TextChanged(object sender, EventArgs e)
        {
            if (metroTbMaKhach.Text != "" && conf.simpleQuery2("select * from khach where makh = " + metroTbMaKhach.Text.Trim(), 0) != null)
            {
                metroTbTenKhach.Text = conf.simpleQuery2("select * from khach where makh = " + metroTbMaKhach.Text.Trim(), 0).Rows[0].Field<string>("hotenkh");
                metroTbDiaChi.Text = conf.simpleQuery2("select * from khach where makh = " + metroTbMaKhach.Text.Trim(), 0).Rows[0].Field<string>("diachi");
                metroTbSdt.Text = conf.simpleQuery2("select * from khach where makh = " + metroTbMaKhach.Text.Trim(), 0).Rows[0].Field<double>("dienthoai").ToString();
            }
            else
            {
                metroTbTenKhach.ResetText();
                metroTbDiaChi.ResetText();
                metroTbSdt.ResetText();
                metroTbTongTien.ResetText();
            }
        }

        ////////////nhap kho//////////////////
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
                    int r = Convert.ToInt32(metroGridNhapKho.Rows[row].Cells[1].Value);
                    int c = r + Convert.ToInt32(sl);
                    do_v(c, tenSp);
                }
                else { MessageBox.Show("Vui lòng nhập lại hộ mị nhé bé ơi!"); }
            }
        }

        private void metroBtNhapKho_Click(object sender, EventArgs e)
        {
            //metroTbTenKhach
            string s1 = metroTbNhapGa.Text;
            string s2 = metroTbHam.Text;
            string s3 = metroTbDon.Text;

            nhapKho(s1, 0, metroLbGa.Text);
            nhapKho(s2, 1, metroLbHam.Text);
            nhapKho(s3, 2, metroLbDon.Text);
        }

        private void metroBtReload_Click(object sender, EventArgs e)
        {
            loaddatasp();
            metroBtReload.Enabled = true;
        }


        /// tai khoan
        private void metroBtDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form3();
            frm.ShowDialog();
            this.Close();
        }

        private void metroBtQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.ShowDialog();
        }
        /// thong ke
        private void metroBtThongKe_Click(object sender, EventArgs e)
        {
            if (metroRbKhoangTg.Checked == true)
            {
                metroGridThongKe.DataSource = conf.simpleQuery2("select DISTINCT khach.hotenkh, khach.diachi, khach.dienthoai, hoadon.ngaynhap, sanpham.tensp, chitiethoadon.soluongmua, chitiethoadon.tongtien from hoadon,chitiethoadon,sanpham,khach where hoadon.mahd = chitiethoadon.mahd AND hoadon.makh = khach.makh AND chitiethoadon.masp = sanpham.masp and ngaynhap between '" + formatDate(metroDateTimeBatDau) + "' and '" + formatDate(metroDateTimeKetThuc) + "'", 0);
            }
            else if (metroRbNam.Checked == true)
            {
                metroGridThongKe.DataSource = conf.simpleQuery2("select DISTINCT khach.hotenkh, khach.diachi, khach.dienthoai, hoadon.ngaynhap, sanpham.tensp, chitiethoadon.soluongmua, chitiethoadon.tongtien from hoadon,chitiethoadon,sanpham,khach where hoadon.mahd = chitiethoadon.mahd AND hoadon.makh = khach.makh AND chitiethoadon.masp = sanpham.masp and YEAR(ngaynhap) = " + metroDateTimeNam.Text, 0);
            }
            else if (metroRbMatHang.Checked == true)
            {
                if (metroCbMatHang.SelectedItem != null)
                {
                    metroGridThongKe.DataSource = conf.simpleQuery2("select sanpham.tensp, SUM(chitiethoadon.soluongmua) as soluongdaban, SUM(chitiethoadon.tongtien) as tongtien from sanpham, chitiethoadon where sanpham.masp = chitiethoadon.masp and tensp = N'" + metroCbMatHang.SelectedItem.ToString() + "' group by sanpham.tensp", 0);
                }
                else
                {
                    metroGridThongKe.DataSource = conf.simpleQuery2("select sanpham.tensp, SUM(chitiethoadon.soluongmua) as soluongdaban, SUM(chitiethoadon.tongtien) as tongtien from sanpham, chitiethoadon where sanpham.masp = chitiethoadon.masp group by sanpham.tensp", 0);
                }
            }
            else if (metroRbThang.Checked == true)
            {
                if (metroCbThang.SelectedItem != null)
                {
                    metroGridThongKe.DataSource = conf.simpleQuery2("select DISTINCT khach.hotenkh, khach.diachi, khach.dienthoai, hoadon.ngaynhap, sanpham.tensp, chitiethoadon.soluongmua, chitiethoadon.tongtien from hoadon,chitiethoadon,sanpham,khach where hoadon.mahd = chitiethoadon.mahd AND hoadon.makh = khach.makh AND chitiethoadon.masp = sanpham.masp and MONTH(ngaynhap) = " + metroCbThang.SelectedItem.ToString(), 0);
                }
                else
                {
                    metroGridThongKe.DataSource = conf.simpleQuery2("select MONTH(ngaynhap) as thang, Year(ngaynhap) as nam, sanpham.tensp, sum(chitiethoadon.soluongmua) as soluongmua, sum(chitiethoadon.tongtien) as tongtien from hoadon,chitiethoadon,sanpham where hoadon.mahd = chitiethoadon.mahd AND chitiethoadon.masp = sanpham.masp group by MONTH(ngaynhap), Year(ngaynhap), tensp", 0);
                }
            }
            else if (metroRbKhach.Checked == true)
            {
                metroGridThongKe.DataSource = conf.simpleQuery2("select khach.hotenkh, sum(chitiethoadon.soluongmua) as soluongmua, sum(chitiethoadon.tongtien) as tongtien from khach, hoadon, chitiethoadon where khach.makh = hoadon.makh and hoadon.mahd = chitiethoadon.mahd group by khach.hotenkh", 0);
            }
            else if (metroRbNhanVien.Checked == true)
            {

                metroGridThongKe.DataSource = conf.simpleQuery2("select nhanvien.idnv,nhanvien.tennv,sdt,diachi,email,trangthai,sum(soluongmua) as soluongban, sum(tongtien) as doanhthu from nhanvien, hoadon, chitiethoadon, sanpham where nhanvien.idnv = hoadon.idnv and hoadon.mahd = chitiethoadon.mahd and chitiethoadon.masp = sanpham.masp group by nhanvien.idnv,nhanvien.tennv,sdt,diachi,email,trangthai", 0);
            }
        }

        
    }
}
