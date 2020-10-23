using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace RegisterPhones
{
    public partial class AddAccidentForm : Form
    {
        public AddAccidentForm()
        {
            InitializeComponent();
            
            if (Form1.Button == "Edit")
            {              
                switch (PhoneObj.ObjAccident.District)
                {
                    case "ЗАО":
                        radioButton_ZAO.Checked = true;
                        break;
                    case "ЖКС3":
                        radioButton_GKS3.Checked = true;
                        break;
                    case "СЕВЕР":
                        radioButton_North.Checked = true;
                        break;
                    case "ЮГ":
                        radioButton_South.Checked = true;
                        break;
                    default:
                        break;
                }

                textBox_Adress.Text = PhoneObj.ObjAccident.Street;
                richTextBox1.Text = PhoneObj.ObjAccident.Accident;
                textBox_time.Text = PhoneObj.ObjAccident.DateCall;
            }
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
            
            if (Form1.Button == "Add")
                PhoneObj.AddAccident(new PhoneObj(district, textBox_Adress.Text, richTextBox1.Text, textBox_time.Text));
            if (Form1.Button == "Edit")
                PhoneObj.ChangeAccident(PhoneObj.ObjAccident,new PhoneObj(district, textBox_Adress.Text, richTextBox1.Text, textBox_time.Text));
            Close();
        }

    }
}
