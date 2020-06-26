using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Palette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int i1 = Convert.ToInt32(trackBar1.Value);
            int i2 = Convert.ToInt32(trackBar2.Value);
            int i3 = Convert.ToInt32(trackBar3.Value);
            label1.Text = "Red("+trackBar1.Value+"):";
            textBox1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            toolTip1.SetToolTip(textBox1, "#"+ Convert.ToString(i1, 16)+ Convert.ToString(i2, 16)+Convert.ToString(i3, 16));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int i1 = Convert.ToInt32(trackBar1.Value);
            int i2 = Convert.ToInt32(trackBar2.Value);
            int i3 = Convert.ToInt32(trackBar3.Value);
            label2.Text = "Green(" + trackBar2.Value + "):";
            textBox1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            toolTip1.SetToolTip(textBox1, "#" + Convert.ToString(i1, 16) + Convert.ToString(i2, 16) + Convert.ToString(i3, 16));
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int i1 = Convert.ToInt32(trackBar1.Value);
            int i2 = Convert.ToInt32(trackBar2.Value);
            int i3 = Convert.ToInt32(trackBar3.Value);
            label3.Text = "Blue(" + trackBar3.Value + "):";
            textBox1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            toolTip1.SetToolTip(textBox1, "#" + Convert.ToString(i1, 16) + Convert.ToString(i2, 16) + Convert.ToString(i3, 16));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //toolTip1.Show("текст toolTip`а", textBox1, 2000);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (true) e.Handled = true;
        }
    }
}
