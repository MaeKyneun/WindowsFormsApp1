using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            //Сообщения при наведении на кнопки
            toolTip1.SetToolTip(this.button1, "Создать собственное меню");
            toolTip1.SetToolTip(this.button2, "Выбрать готовое меню");
            toolTip1.SetToolTip(this.button3, "Закрыть приложение");
            toolTip1.SetToolTip(this.button4, "Посмотреть сохраненные меню");
            toolTip1.SetToolTip(this.pictureBox1, "Информация о приложении");
        }

        private void Form1_Load(object sender, PaintEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e) //создать
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //выход
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Данное приложение разработано для любителей покушать. Автор: Пономарчук А.А. ПБТ-22"); //сообщение о создателе
        }

        private void button2_Click(object sender, EventArgs e) //готовое меню
        {

            Form4 f4 = new Form4();
            f4.Show();

        }
    }
}
