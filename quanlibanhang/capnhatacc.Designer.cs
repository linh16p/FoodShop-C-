namespace quanlibanhang
{
    partial class capnhatacc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtennd = new System.Windows.Forms.TextBox();
            this.tbmatkhaucu = new System.Windows.Forms.TextBox();
            this.tbmatkhaumoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btlogin = new System.Windows.Forms.Button();
            this.btback = new System.Windows.Forms.Button();
            this.tbxacnhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvdangnhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdangnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tên người dùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "mật khẩu cũ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbtennd
            // 
            this.tbtennd.Location = new System.Drawing.Point(134, 78);
            this.tbtennd.Name = "tbtennd";
            this.tbtennd.Size = new System.Drawing.Size(202, 20);
            this.tbtennd.TabIndex = 2;
            // 
            // tbmatkhaucu
            // 
            this.tbmatkhaucu.Location = new System.Drawing.Point(134, 104);
            this.tbmatkhaucu.Name = "tbmatkhaucu";
            this.tbmatkhaucu.Size = new System.Drawing.Size(202, 20);
            this.tbmatkhaucu.TabIndex = 4;
            // 
            // tbmatkhaumoi
            // 
            this.tbmatkhaumoi.Location = new System.Drawing.Point(134, 130);
            this.tbmatkhaumoi.Name = "tbmatkhaumoi";
            this.tbmatkhaumoi.Size = new System.Drawing.Size(202, 20);
            this.tbmatkhaumoi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "mật khẩu mới:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(134, 200);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 23);
            this.btlogin.TabIndex = 7;
            this.btlogin.Text = "login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(261, 200);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(75, 23);
            this.btback.TabIndex = 8;
            this.btback.Text = "back";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // tbxacnhan
            // 
            this.tbxacnhan.Location = new System.Drawing.Point(134, 156);
            this.tbxacnhan.Name = "tbxacnhan";
            this.tbxacnhan.Size = new System.Drawing.Size(202, 20);
            this.tbxacnhan.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "nhập lại mật khẩu:";
            // 
            // dgvdangnhap
            // 
            this.dgvdangnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdangnhap.Location = new System.Drawing.Point(12, 229);
            this.dgvdangnhap.Name = "dgvdangnhap";
            this.dgvdangnhap.Size = new System.Drawing.Size(389, 100);
            this.dgvdangnhap.TabIndex = 11;
            // 
            // capnhatacc
            // 
            this.AcceptButton = this.btlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 341);
            this.Controls.Add(this.dgvdangnhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxacnhan);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbmatkhaumoi);
            this.Controls.Add(this.tbmatkhaucu);
            this.Controls.Add(this.tbtennd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "capnhatacc";
            this.Text = "capnhatacc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.capnhatacc_FormClosing);
            this.Load += new System.EventHandler(this.capnhatacc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdangnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtennd;
        private System.Windows.Forms.TextBox tbmatkhaucu;
        private System.Windows.Forms.TextBox tbmatkhaumoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.TextBox tbxacnhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvdangnhap;
    }
}