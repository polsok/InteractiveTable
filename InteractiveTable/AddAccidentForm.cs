using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InteractiveTable
{
    public partial class AddAccidentForm : Form
    {
        public AddAccidentForm()
        {
            InitializeComponent();
            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //проверяем что все поля заполнены
            if (radioButton_GKS3.Checked != true && radioButton_North.Checked != true &&
                radioButton_South.Checked != true && radioButton_ZAO.Checked != true)
            {
                MessageBox.Show("Не выбран район");
                return;
            }

            if (textBox_Adress.Text.Length < 5)
            {
                MessageBox.Show("Не указан адрес");
                return;
            }

            if (richTextBox1.Text.Length < 5)
            {
                MessageBox.Show("Не указано происшествие");
                return;
            }

            if (textBox_time.Text.Length < 3)
            {
                MessageBox.Show("Не указано время");
                return;
            }

            string district = "";
            if (radioButton_ZAO.Checked == true)
                district = "ЗАО";
            if (radioButton_GKS3.Checked == true)
                district = "ЖКС3";
            if (radioButton_North.Checked == true)
                district = "СЕВЕР";
            if (radioButton_South.Checked == true)
                district = "ЮГ";
            string appendLine = "\n"+Program.ID + ",\"" + DateTime.Now.ToString("F") + "\",\"" + textBox_Adress.Text +
                                "\",\"" + richTextBox1.Text + "\",\"" + textBox_time.Text + "\",\"" +
                                Environment.UserName + "\",\"" + "\",\"" + district + "\"";
            File.AppendAllText("Data.csv", appendLine);
            Close();
        }
    }
}
