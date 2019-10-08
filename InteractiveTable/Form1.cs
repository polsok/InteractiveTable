using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace InteractiveTable
{
    
    public partial class Form1 : Form
    {
        static bool _buttonSouthEnabled = false;
        static bool _buttonNordEnabled = false;
        static bool _buttonVasEnabled = false;
        static bool _buttonGks3Enabled = false;       
        
        public Form1()
        {
            InitializeComponent();

            #region Загружаем данные раз в 10 секунд


                Program.ID = 0;
                Program.DataList.Clear();
                string[] ReadFile = DownFile("Data.csv");
                for (int i = 0; i < ReadFile.Length; i++)
                {
                    var t = new List<string>();
                    var csvSplit = new Regex("((?<=\")[^\"]*(?=\"(,|$)+)|(?<=,|^)[^,\"]*(?=,|$))", RegexOptions.Compiled);

                    foreach (Match match in csvSplit.Matches(ReadFile[i]))
                        t.Add(match.Value.TrimStart(','));
                    if (t.Count < 4)
                        continue;
                    //обрабатываем данные
                    Accident data = new Accident();
                    data.ID = Convert.ToInt32(t[0]);
                    data.DataTime = t[1];
                    data.Adress = t[2];
                    data._Accident = t[3];
                    data.TimeAccident = t[4];
                    data.AddDispetcher = t[5];
                    data.RemoveDispetcher = t[6];
                    data.District = t[7];
                    Program.ID = data.ID + 1;
                    Program.DataList.Add(data);
                }

            //обработчик события

            #endregion

        }
        /// <summary>
        /// событие заполнения ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewCompleting(object sender, EventArgs e)
        {
            string t = sender.ToString();
            switch (t)
            {
                case "System.Windows.Forms.Button, Text: ЮГ":
                    if (_buttonSouthEnabled)
                    {
                        button_South.BackColor = System.Drawing.Color.White;
                        _buttonSouthEnabled = false;
                    }
                    else
                    {
                        button_South.BackColor = System.Drawing.Color.Red;
                        _buttonSouthEnabled = true;
                    }
                    break;
                case "System.Windows.Forms.Button, Text: СЕВЕР":
                    if (_buttonNordEnabled)
                    {
                        button_Nord.BackColor = System.Drawing.Color.White;
                        _buttonNordEnabled = false;
                    }
                    else
                    {
                        button_Nord.BackColor = System.Drawing.Color.Aqua;
                        _buttonNordEnabled = true;
                    }
                    break;
                case "System.Windows.Forms.Button, Text: ЗАО":
                    if (_buttonVasEnabled)
                    {
                        button_Vas.BackColor = System.Drawing.Color.White;
                        _buttonVasEnabled = false;
                    }
                    else
                    {
                        button_Vas.BackColor = System.Drawing.Color.Green;
                        _buttonVasEnabled = true;
                    }
                    break;
                case "System.Windows.Forms.Button, Text: ЖКС3":
                    if (_buttonGks3Enabled)
                    {
                        button_GKS3.BackColor = System.Drawing.Color.White;
                        _buttonGks3Enabled = false;
                    }
                    else
                    {
                        button_GKS3.BackColor = System.Drawing.Color.Yellow;
                        _buttonGks3Enabled = true;
                    }
                    break;
                default:
                    break;
            }
            listView1.Items.Clear();
            int k = 0;
            for (int i = 0; i < Program.DataList.Count; i++)
            {
                if (_buttonGks3Enabled && Program.DataList[i].District == "ЖКС3")
                {
                    listView1.Items.Add(Convert.ToString(Program.DataList[i].ID));
                    listView1.Items[k].SubItems.Add(Program.DataList[i].Adress);
                    listView1.Items[k].SubItems.Add(Program.DataList[i]._Accident);
                    listView1.Items[k].SubItems.Add(Program.DataList[i].TimeAccident);
                    listView1.Items[k].SubItems.Add(Program.DataList[i].AddDispetcher);
                    k++;
                }
                if (_buttonNordEnabled && Program.DataList[i].District == "СЕВЕР")
                {
                    listView1.Items.Add(Convert.ToString(Program.DataList[i].ID));
                    listView1.Items[k].SubItems.Add(Program.DataList[i].Adress);
                    listView1.Items[k].SubItems.Add(Program.DataList[i]._Accident);
                    listView1.Items[k].SubItems.Add(Program.DataList[i].TimeAccident);
                    listView1.Items[k].SubItems.Add(Program.DataList[i].AddDispetcher);
                    k++;
                }
                if (_buttonSouthEnabled && Program.DataList[i].District == "ЮГ")
                {
                    listView1.Items.Add(Convert.ToString(Program.DataList[i].ID));
                    listView1.Items[k].SubItems.Add(Program.DataList[i].Adress);
                    listView1.Items[k].SubItems.Add(Program.DataList[i]._Accident);
                    listView1.Items[k].SubItems.Add(Program.DataList[i].TimeAccident);
                    listView1.Items[k].SubItems.Add(Program.DataList[i].AddDispetcher);
                    k++;
                }
                if (_buttonVasEnabled && Program.DataList[i].District == "ЗАО")
                {
                    listView1.Items.Add(Convert.ToString(Program.DataList[i].ID));
                    listView1.Items[k].SubItems.Add(Program.DataList[i].Adress);
                    listView1.Items[k].SubItems.Add(Program.DataList[i]._Accident);
                    listView1.Items[k].SubItems.Add(Program.DataList[i].TimeAccident);
                    listView1.Items[k].SubItems.Add(Program.DataList[i].AddDispetcher);
                    k++;
                }
            }
        }
    
        #region загрузка данных из файла открытого в режиме чтения

        /// <summary>
        /// загрузка данных из файла открытого в режиме чтения
        /// </summary>
        internal static string[] DownFile(string path)
        {
            FileInfo log = new FileInfo(path);
            string text;
            using (var streamReader = new StreamReader(log.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            {
                text = streamReader.ReadToEnd();
            }

            text = text.Replace("\r", "");
            char[] chars = { '\n' };
            string[] R = text.Split(chars);
            return R;

        }


        #endregion

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddAccidentForm newForm = new AddAccidentForm();
            newForm.Show();
        }

    }
}
