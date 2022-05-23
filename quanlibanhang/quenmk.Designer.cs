namespace quanlibanhang
{
    partial class quenmk
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbxacnhan = new System.Windows.Forms.TextBox();
            this.btback = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmatkhaumoi = new System.Windows.Forms.TextBox();
            this.tbmatkhaucu = new System.Windows.Forms.TextBox();
            this.tbtennd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "nhập lại mật khẩu:";
            // 
            // tbxacnhan
            // 
            this.tbxacnhan.Location = new System.Drawing.Point(129, 213);
            this.tbxacnhan.Name = "tbxacnhan";
            this.tbxacnhan.Size = new System.Drawing.Size(210, 20);
            this.tbxacnhan.TabIndex = 19;
            // 
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(256, 257);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(83, 36);
            this.btback.TabIndex = 18;
            this.btback.Text = "back";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(129, 257);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(83, 36);
            this.btlogin.TabIndex = 17;
            this.btlogin.Text = "login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "mật khẩu mới:";
            // 
            // tbmatkhaumoi
            // 
            this.tbmatkhaumoi.Location = new System.Drawing.Point(129, 187);
            this.tbmatkhaumoi.Name = "tbmatkhaumoi";
            this.tbmatkhaumoi.Size = new System.Drawing.Size(210, 20);
            this.tbmatkhaumoi.TabIndex = 15;
            // 
            // tbmatkhaucu
            // 
            this.tbmatkhaucu.Location = new System.Drawing.Point(129, 161);
            this.tbmatkhaucu.Name = "tbmatkhaucu";
            this.tbmatkhaucu.Size = new System.Drawing.Size(210, 20);
            this.tbmatkhaucu.TabIndex = 14;
            // 
            // tbtennd
            // 
            this.tbtennd.Location = new System.Drawing.Point(129, 135);
            this.tbtennd.Name = "tbtennd";
            this.tbtennd.Size = new System.Drawing.Size(210, 20);
            this.tbtennd.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "email: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "tên người dùng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "QUÊN MẬT KHẨU";
            // 
            // quenmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 368);
            this.Controls.Add(this.label5);
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
            this.Name = "quenmk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUÊN MẬT KHẨU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quenmk_FormClosing);
            this.Load += new System.EventHandler(this.quenmk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxacnhan;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmatkhaumoi;
        private System.Windows.Forms.TextBox tbmatkhaucu;
        private System.Windows.Forms.TextBox tbtennd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}