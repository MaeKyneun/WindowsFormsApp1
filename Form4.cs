using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.pictureBox4, "Закрыть данный раздел");
            toolTip1.SetToolTip(this.pictureBox1, "Нажми и перейдешь в нужный раздел");
            toolTip1.SetToolTip(this.pictureBox2, "Нажми и перейдешь в нужный раздел");
            toolTip1.SetToolTip(this.pictureBox3, "Нажми и перейдешь в нужный раздел");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e) //выход
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
