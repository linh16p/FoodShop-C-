namespace quanlibanhang
{
    partial class createacc
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME:";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(150, 118);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(181, 20);
            this.tbemail.TabIndex = 3;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(150, 157);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(181, 20);
            this.tbname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PASS:";
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(150, 190);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(181, 20);
            this.tbpass.TabIndex = 6;
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(150, 243);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(74, 31);
            this.accept.TabIndex = 7;
            this.accept.Text = "ACCEPT";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(257, 243);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(74, 31);
            this.done.TabIndex = 8;
            this.done.Text = "DONE";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // createacc
            // 
            this.AcceptButton = this.accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 364);
            this.Controls.Add(this.done);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "createacc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TẠO TÀI KHOẢN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.createacc_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button done;
    }
}