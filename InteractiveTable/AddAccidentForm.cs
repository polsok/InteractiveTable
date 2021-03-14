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

namespace InteractiveTable
{
    public partial class AddAccidentForm : Form
    {
        public AddAccidentForm()
        {
            InitializeComponent();
            
            if (Form1.Button == "Edit")
            {              
                switch (AccidentObj.ObjAccident.District)
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
                    case "ЛИФТЫ":
                        radioButton_ELEV.Checked = true;
                        break;
                    case "ИНФО":
                        radioButton_INFO.Checked = true;
                        break;
                    default:
                        break;
                }

                textBox_Adress.Text = AccidentObj.ObjAccident.Adress;
                richTextBox1.Text = AccidentObj.ObjAccident.Accident;
                textBox_time.Text = AccidentObj.ObjAccident.TimeAccident;
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
                radioButton_South.Checked != true && radioButton_ZAO.Checked != true &&
                radioButton_ELEV.Checked != true && radioButton_INFO.Checked != true)
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
            if (radioButton_ELEV.Checked == true)
                district = "ЛИФТЫ";
            if (radioButton_INFO.Checked == true)
                district = "ИНФО";

            if (Form1.Button == "Add")
                AccidentObj.AddAccident(new AccidentObj(district, textBox_Adress.Text, richTextBox1.Text, textBox_time.Text));
            if (Form1.Button == "Edit")
                AccidentObj.ChangeAccident(AccidentObj.ObjAccident,new AccidentObj(district, textBox_Adress.Text, richTextBox1.Text, textBox_time.Text));
            Close();
        }

    }
}
