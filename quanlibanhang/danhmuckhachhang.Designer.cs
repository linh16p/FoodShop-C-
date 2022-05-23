namespace quanlibanhang
{
    partial class danhmuckhachhang
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbthanhpho = new System.Windows.Forms.ComboBox();
            this.tbdienthoai = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.tbtencty = new System.Windows.Forms.TextBox();
            this.tbmakh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhpho = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btreload = new System.Windows.Forms.Button();
            this.btADD = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.qlbanhangDataSet = new quanlibanhang.qlbanhangDataSet();
            this.thanhPhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thanhPhoTableAdapter = new quanlibanhang.qlbanhangDataSetTableAdapters.thanhPhoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbanhangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhPhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbthanhpho);
            this.panel1.Controls.Add(this.tbdienthoai);
            this.panel1.Controls.Add(this.tbdiachi);
            this.panel1.Controls.Add(this.tbtencty);
            this.panel1.Controls.Add(this.tbmakh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 167);
            this.panel1.TabIndex = 0;
            // 
            // cbthanhpho
            // 
            this.cbthanhpho.DisplayMember = "tenthanhpho";
            this.cbthanhpho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbthanhpho.FormattingEnabled = true;
            this.cbthanhpho.Location = new System.Drawing.Point(559, 17);
            this.cbthanhpho.Name = "cbthanhpho";
            this.cbthanhpho.Size = new System.Drawing.Size(166, 21);
            this.cbthanhpho.TabIndex = 9;
            this.cbthanhpho.ValueMember = "thanhPho";
            this.cbthanhpho.SelectedIndexChanged += new System.EventHandler(this.cbthanhpho_SelectedIndexChanged);
            // 
            // tbdienthoai
            // 
            this.tbdienthoai.Location = new System.Drawing.Point(559, 54);
            this.tbdienthoai.Name = "tbdienthoai";
            this.tbdienthoai.Size = new System.Drawing.Size(166, 20);
            this.tbdienthoai.TabIndex = 8;
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(82, 105);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(309, 20);
            this.tbdiachi.TabIndex = 7;
            // 
            // tbtencty
            // 
            this.tbtencty.Location = new System.Drawing.Point(82, 61);
            this.tbtencty.Name = "tbtencty";
            this.tbtencty.Size = new System.Drawing.Size(309, 20);
            this.tbtencty.TabIndex = 6;
            // 
            // tbmakh
            // 
            this.tbmakh.Location = new System.Drawing.Point(82, 20);
            this.tbmakh.Name = "tbmakh";
            this.tbmakh.Size = new System.Drawing.Size(131, 20);
            this.tbmakh.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ĐIỆN THOẠI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "THÀNH PHỐ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ĐỊA CHỈ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN CTY:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ KH:";
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.AllowUserToAddRows = false;
            this.dgvkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tencty,
            this.diachi,
            this.thanhpho,
            this.dienthoai});
            this.dgvkhachhang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvkhachhang.Location = new System.Drawing.Point(0, 173);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.Size = new System.Drawing.Size(800, 228);
            this.dgvkhachhang.TabIndex = 1;
            this.dgvkhachhang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvkhachhang_CellMouseClick);
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "mã khách";
            this.makh.Name = "makh";
            // 
            // tencty
            // 
            this.tencty.DataPropertyName = "tencty";
            this.tencty.HeaderText = "tên cty";
            this.tencty.Name = "tencty";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // thanhpho
            // 
            this.thanhpho.DataPropertyName = "thanhpho";
            this.thanhpho.HeaderText = "thành phố";
            this.thanhpho.Name = "thanhpho";
            this.thanhpho.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.thanhpho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "điện thoại";
            this.dienthoai.Name = "dienthoai";
            // 
            // btreload
            // 
            this.btreload.Location = new System.Drawing.Point(12, 415);
            this.btreload.Name = "btreload";
            this.btreload.Size = new System.Drawing.Size(75, 23);
            this.btreload.TabIndex = 2;
            this.btreload.Text = "Reload";
            this.btreload.UseVisualStyleBackColor = true;
            this.btreload.Click += new System.EventHandler(this.btreload_Click);
            // 
            // btADD
            // 
            this.btADD.Location = new System.Drawing.Point(138, 415);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(75, 23);
            this.btADD.TabIndex = 3;
            this.btADD.Text = "ADD";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(265, 415);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "EDIT";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(380, 415);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 5;
            this.btdelete.Text = "delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(496, 415);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(75, 23);
            this.btsave.TabIndex = 6;
            this.btsave.Text = "SAVE";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(606, 415);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(75, 23);
            this.btcancel.TabIndex = 7;
            this.btcancel.Text = "cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(713, 415);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 8;
            this.btthoat.Text = "Exit";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // qlbanhangDataSet
            // 
            this.qlbanhangDataSet.DataSetName = "qlbanhangDataSet";
            this.qlbanhangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thanhPhoBindingSource
            // 
            this.thanhPhoBindingSource.DataMember = "thanhPho";
            this.thanhPhoBindingSource.DataSource = this.qlbanhangDataSet;
            // 
            // thanhPhoTableAdapter
            // 
            this.thanhPhoTableAdapter.ClearBeforeFill = true;
            // 
            // danhmuckhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.btreload);
            this.Controls.Add(this.dgvkhachhang);
            this.Controls.Add(this.panel1);
            this.Name = "danhmuckhachhang";
            this.Text = "DANH MỤC KHÁCH HÀNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.danhmuckhachhang_FormClosing);
            this.Load += new System.EventHandler(this.danhmuckhachhang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbanhangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhPhoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.ComboBox cbthanhpho;
        private System.Windows.Forms.TextBox tbdienthoai;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.TextBox tbtencty;
        private System.Windows.Forms.TextBox tbmakh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btreload;
        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btthoat;
        private qlbanhangDataSet qlbanhangDataSet;
        private System.Windows.Forms.BindingSource thanhPhoBindingSource;
        private qlbanhangDataSetTableAdapters.thanhPhoTableAdapter thanhPhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencty;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewComboBoxColumn thanhpho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
    }
}