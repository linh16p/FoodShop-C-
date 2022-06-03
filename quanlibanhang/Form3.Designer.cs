namespace quanlibanhang
{
    partial class Form3
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTbUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroTbPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(44, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(129, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Tên đăng nhập:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(86, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 25);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Mật khẩu:";
            // 
            // metroTbUserName
            // 
            // 
            // 
            // 
            this.metroTbUserName.CustomButton.Image = null;
            this.metroTbUserName.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.metroTbUserName.CustomButton.Name = "";
            this.metroTbUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTbUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTbUserName.CustomButton.TabIndex = 1;
            this.metroTbUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTbUserName.CustomButton.UseSelectable = true;
            this.metroTbUserName.CustomButton.Visible = false;
            this.metroTbUserName.Lines = new string[0];
            this.metroTbUserName.Location = new System.Drawing.Point(195, 92);
            this.metroTbUserName.MaxLength = 32767;
            this.metroTbUserName.Name = "metroTbUserName";
            this.metroTbUserName.PasswordChar = '\0';
            this.metroTbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTbUserName.SelectedText = "";
            this.metroTbUserName.SelectionLength = 0;
            this.metroTbUserName.SelectionStart = 0;
            this.metroTbUserName.ShortcutsEnabled = true;
            this.metroTbUserName.Size = new System.Drawing.Size(195, 23);
            this.metroTbUserName.TabIndex = 12;
            this.metroTbUserName.UseSelectable = true;
            this.metroTbUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTbUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTbPassword
            // 
            // 
            // 
            // 
            this.metroTbPassword.CustomButton.Image = null;
            this.metroTbPassword.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.metroTbPassword.CustomButton.Name = "";
            this.metroTbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTbPassword.CustomButton.TabIndex = 1;
            this.metroTbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTbPassword.CustomButton.UseSelectable = true;
            this.metroTbPassword.CustomButton.Visible = false;
            this.metroTbPassword.Lines = new string[0];
            this.metroTbPassword.Location = new System.Drawing.Point(195, 127);
            this.metroTbPassword.MaxLength = 32767;
            this.metroTbPassword.Name = "metroTbPassword";
            this.metroTbPassword.PasswordChar = '❤';
            this.metroTbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTbPassword.SelectedText = "";
            this.metroTbPassword.SelectionLength = 0;
            this.metroTbPassword.SelectionStart = 0;
            this.metroTbPassword.ShortcutsEnabled = true;
            this.metroTbPassword.Size = new System.Drawing.Size(195, 23);
            this.metroTbPassword.TabIndex = 13;
            this.metroTbPassword.UseSelectable = true;
            this.metroTbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(111, 192);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 27);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "đăng nhập";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton2.Location = new System.Drawing.Point(244, 192);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(104, 27);
            this.metroButton2.TabIndex = 15;
            this.metroButton2.Text = "thoát";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Form3
            // 
            this.AcceptButton = this.metroButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.metroButton2;
            this.ClientSize = new System.Drawing.Size(462, 258);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTbPassword);
            this.Controls.Add(this.metroTbUserName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form3";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTbUserName;
        private MetroFramework.Controls.MetroTextBox metroTbPassword;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}