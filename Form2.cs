using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e) //выход
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //советы
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e) //сохранить
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Текстовые файлы |*.txt",
                Title = "Сохранить"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFile.FileName,
                    FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fileStream, Encoding.UTF8);
                writer.WriteLine(label23.Text + " " + richTextBox22.Text); //название меню
                
                writer.WriteLine(groupBox1.Text); //понедельник
                writer.WriteLine(label1.Text + " : " + richTextBox1.Text); //завтрак
                writer.WriteLine(label2.Text + " : " + richTextBox2.Text); //обед
                writer.WriteLine(label3.Text + " : " + richTextBox3.Text); //ужин

                writer.WriteLine(groupBox7.Text); //вторник
                writer.WriteLine(label21.Text + " : " + richTextBox21.Text); //завтрак
                writer.WriteLine(label20.Text + " : " + richTextBox20.Text); //обед
                writer.WriteLine(label19.Text + " : " + richTextBox19.Text); //ужин

                writer.WriteLine(groupBox2.Text); //среда
                writer.WriteLine(label6.Text + " : " + richTextBox6.Text); //завтрак
                writer.WriteLine(label5.Text + " : " + richTextBox5.Text); //обед
                writer.WriteLine(label4.Text + " : " + richTextBox4.Text); //ужин

                writer.WriteLine(groupBox6.Text); //четверг
                writer.WriteLine(label18.Text + " : " + richTextBox18.Text); //завтрак
                writer.WriteLine(label17.Text + " : " + richTextBox17.Text); //обед
                writer.WriteLine(label16.Text + " : " + richTextBox16.Text); //ужин

                writer.WriteLine(groupBox3.Text); //пятница
                writer.WriteLine(label9.Text + " : " + richTextBox9.Text); //завтрак
                writer.WriteLine(label8.Text + " : " + richTextBox8.Text); //обед
                writer.WriteLine(label7.Text + " : " + richTextBox7.Text); //ужин

                writer.WriteLine(groupBox5.Text); //Суббота
                writer.WriteLine(label15.Text + " : " + richTextBox15.Text); //завтрак
                writer.WriteLine(label14.Text + " : " + richTextBox14.Text); //обед
                writer.WriteLine(label13.Text + " : " + richTextBox13.Text); //ужин

                writer.WriteLine(groupBox4.Text); //Воскресенье
                writer.WriteLine(label12.Text + " : " + richTextBox12.Text); //завтрак
                writer.WriteLine(label11.Text + " : " + richTextBox11.Text); //обед
                writer.WriteLine(label10.Text + " : " + richTextBox10.Text); //ужин
                writer.Dispose();

                DialogResult res = MessageBox.Show("Новое меню созданно!"); //сообщение о сохранении
            }
        }

        private void richTextBox22_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
