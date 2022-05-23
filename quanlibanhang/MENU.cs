using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlibanhang
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if(gao.Value!=0)
            {
                dataGridView1.Rows.Add("Gạo", "100000", n, m);
            }
            else
            { }
        }
        int n;
        int m;
        private void gao_ValueChanged(object sender, EventArgs e)
        {
            n = Convert.ToInt32(gao.Value);
            if(n>=10)
            {
                m = ((n*100000)-(n*100000/100));
            }
            else
            { m = n * 100000; }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //object lol;
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            
            t.SetToolTip((PictureBox)sender, "chai sting đỏ giá 20.000");
            t.ShowAlways =true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();

            t.SetToolTip((PictureBox)sender, "chai đỉnh giá : 15.000");
            t.ShowAlways = true;
        }
    }
}
