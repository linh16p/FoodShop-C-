namespace quanlibanhang
{
    partial class danhmucnhsnvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbdienthoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.dtpngaynv = new System.Windows.Forms.DateTimePicker();
            this.cbsex = new System.Windows.Forms.ComboBox();
            this.tbten = new System.Windows.Forms.TextBox();
            this.tbho = new System.Windows.Forms.TextBox();
            this.tbmanv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btthoat = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btADD = new System.Windows.Forms.Button();
            this.btreload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbdienthoai);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbdiachi);
            this.panel1.Controls.Add(this.dtpngaynv);
            this.panel1.Controls.Add(this.cbsex);
            this.panel1.Controls.Add(this.tbten);
            this.panel1.Controls.Add(this.tbho);
            this.panel1.Controls.Add(this.tbmanv);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 167);
            this.panel1.TabIndex = 0;
            // 
            // tbdienthoai
            // 
            this.tbdienthoai.Location = new System.Drawing.Point(445, 131);
            this.tbdienthoai.Name = "tbdienthoai";
            this.tbdienthoai.Size = new System.Drawing.Size(212, 20);
            this.tbdienthoai.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "điện thoại";
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(445, 99);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(212, 20);
            this.tbdiachi.TabIndex = 11;
            // 
            // dtpngaynv
            // 
            this.dtpngaynv.CustomFormat = "yyyy/MM/dd";
            this.dtpngaynv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaynv.Location = new System.Drawing.Point(445, 58);
            this.dtpngaynv.Name = "dtpngaynv";
            this.dtpngaynv.Size = new System.Drawing.Size(212, 20);
            this.dtpngaynv.TabIndex = 10;
            this.dtpngaynv.ValueChanged += new System.EventHandler(this.dtpngaynv_ValueChanged);
            // 
            // cbsex
            // 
            this.cbsex.DisplayMember = "gioitinh";
            this.cbsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsex.FormattingEnabled = true;
            this.cbsex.Location = new System.Drawing.Point(445, 19);
            this.cbsex.Name = "cbsex";
            this.cbsex.Size = new System.Drawing.Size(40, 21);
            this.cbsex.TabIndex = 9;
            this.cbsex.ValueMember = "nhanvien";
            this.cbsex.SelectedIndexChanged += new System.EventHandler(this.cbsex_SelectedIndexChanged);
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(74, 98);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(170, 20);
            this.tbten.TabIndex = 8;
            // 
            // tbho
            // 
            this.tbho.Location = new System.Drawing.Point(74, 58);
            this.tbho.Name = "tbho";
            this.tbho.Size = new System.Drawing.Size(170, 20);
            this.tbho.TabIndex = 7;
            // 
            // tbmanv
            // 
            this.tbmanv.Location = new System.Drawing.Point(74, 19);
            this.tbmanv.Name = "tbmanv";
            this.tbmanv.Size = new System.Drawing.Size(170, 20);
            this.tbmanv.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ngày nhận việc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ lót";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã nv";
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.AllowUserToAddRows = false;
            this.dgvnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.ho,
            this.ten,
            this.gioitinh,
            this.ngaynv,
            this.diachi,
            this.dienthoai});
            this.dgvnhanvien.Location = new System.Drawing.Point(0, 173);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.Size = new System.Drawing.Size(786, 241);
            this.dgvnhanvien.TabIndex = 1;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "mã nhân viên";
            this.manv.Name = "manv";
            // 
            // ho
            // 
            this.ho.DataPropertyName = "ho";
            this.ho.HeaderText = "Họ lót";
            this.ho.Name = "ho";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ngaynv
            // 
            this.ngaynv.DataPropertyName = "ngaynv";
            this.ngaynv.HeaderText = "ngày nhận v";
            this.ngaynv.Name = "ngaynv";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "điện thoại";
            this.dienthoai.Name = "dienthoai";
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(706, 435);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(66, 23);
            this.btthoat.TabIndex = 15;
            this.btthoat.Text = "Exit";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(599, 435);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(66, 23);
            this.btcancel.TabIndex = 14;
            this.btcancel.Text = "cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(489, 435);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(66, 23);
            this.btsave.TabIndex = 13;
            this.btsave.Text = "SAVE";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(373, 435);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(66, 23);
            this.btdelete.TabIndex = 12;
            this.btdelete.Text = "delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(258, 435);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(66, 23);
            this.btEdit.TabIndex = 11;
            this.btEdit.Text = "EDIT";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btADD
            // 
            this.btADD.Location = new System.Drawing.Point(131, 435);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(66, 23);
            this.btADD.TabIndex = 10;
            this.btADD.Text = "ADD";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // btreload
            // 
            this.btreload.Location = new System.Drawing.Point(5, 434);
            this.btreload.Name = "btreload";
            this.btreload.Size = new System.Drawing.Size(66, 23);
            this.btreload.TabIndex = 9;
            this.btreload.Text = "Reload";
            this.btreload.UseVisualStyleBackColor = true;
            this.btreload.Click += new System.EventHandler(this.btreload_Click);
            // 
            // danhmucnhsnvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 470);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.btreload);
            this.Controls.Add(this.dgvnhanvien);
            this.Controls.Add(this.panel1);
            this.Name = "danhmucnhsnvien";
            this.Text = "danhmucnhsnvien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.danhmucnhsnvien_FormClosing);
            this.Load += new System.EventHandler(this.danhmucnhsnvien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.TextBox tbdienthoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.DateTimePicker dtpngaynv;
        private System.Windows.Forms.ComboBox cbsex;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.TextBox tbho;
        private System.Windows.Forms.TextBox tbmanv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.Button btreload;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
    }
}