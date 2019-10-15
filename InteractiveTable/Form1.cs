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
            Accident.AccidentList = Accident.LoadFile();
            InitializeComponent();
            CreateHeadersAndFillListView();
        }
        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Width = 122;
            colHead.Text = "Адрес";
            listViewAccident.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 214;
            colHead.Text = "Происшествие";
            listViewAccident.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 87;
            colHead.Text = "Время работ";
            listViewAccident.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 83;
            colHead.Text = "Добавил";
            listViewAccident.Columns.Add(colHead);
        }
        /// <summary>
        /// событие заполнения ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ListViewCompleting(object sender, EventArgs e)
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;
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
                //Отработка таймера
                case " [System.Windows.Forms.Timer], Interval: 10000":
                    List<Accident> tempAccidents = Accident.LoadFile();
                    if(tempAccidents == null)
                        return;
                    if (tempAccidents != Accident.AccidentList)
                    {
                        Accident.AccidentList = tempAccidents.GetRange(0, tempAccidents.Count);
                    }
                    else
                        return;
                    break;
                default:
                    break;
            }
            listView1.Items.Clear();
            listViewAccident.Items.Clear();
            if(Accident.AccidentList == null)
                return;
            for (int i = 0; i < Accident.AccidentList.Count; i++)
            {
                if (_buttonGks3Enabled && Accident.AccidentList[i].District == "ЖКС3")
                {
                    lvi = new ListViewItem();
                    lvi.Text = Accident.AccidentList[i].Adress;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Accident.AccidentList[i]._Accident;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Accident.AccidentList[i].TimeAccident;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Accident.AccidentList[i].AddDispetcher;
                    lvi.SubItems.Add(lvsi);

                    listViewAccident.Items.Add(lvi);
                }
                if (_buttonNordEnabled && Accident.AccidentList[i].District == "СЕВЕР")
                {
                    lvi = new ListViewItem();
                    lvi.Text = Accident.AccidentList[i].Adress;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Accident.AccidentList[i]._Accident;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Accident.AccidentList[i].TimeAccident;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Accident.AccidentList[i].AddDispetcher;
                    lvi.SubItems.Add(lvsi);

                    listViewAccident.Items.Add(lvi);
                }
                if (_buttonSouthEnabled && Accident.AccidentList[i].District == "ЮГ")
                {
                    lvi = new ListViewItem();
                    lvi.Text = Accident.AccidentList[i].Adress;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Accident.AccidentList[i]._Accident;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Accident.AccidentList[i].TimeAccident;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Accident.AccidentList[i].AddDispetcher;
                    lvi.SubItems.Add(lvsi);

                    listViewAccident.Items.Add(lvi);
                }
                if (_buttonVasEnabled && Accident.AccidentList[i].District == "ЗАО")
                {
                    lvi = new ListViewItem();
                    lvi.Text = Accident.AccidentList[i].Adress;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Accident.AccidentList[i]._Accident;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Accident.AccidentList[i].TimeAccident;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = Accident.AccidentList[i].AddDispetcher;
                    lvi.SubItems.Add(lvsi);

                    listViewAccident.Items.Add(lvi);
                }
            }
            int k = 0;
            for (int i = 0; i < Accident.AccidentList.Count; i++)
            {
                if (_buttonGks3Enabled && Accident.AccidentList[i].District == "ЖКС3")
                {
                    listView1.Items.Add(Convert.ToString(Accident.AccidentList[i].Adress));
                    listView1.Items[k].SubItems.Add(Accident.AccidentList[i]._Accident);
                    listView1.Items[k].SubItems.Add(Accident.AccidentList[i].TimeAccident);
                    listView1.Items[k].SubItems.Add(Accident.AccidentList[i].AddDispetcher);
                    k++;
                }
                if (_buttonNordEnabled && Accident.AccidentList[i].District == "СЕВЕР")
                {
                    listView1.Items.Add(Convert.ToString(Accident.AccidentList[i].Adress));
                    listView1.Items[k].SubItems.Add(Accident.AccidentList[i]._Accident);
                    listView1.Items[k].SubItems.Add(Accident.AccidentList[i].TimeAccident);
                    listView1.Items[k].SubItems.Add(Accident.AccidentList[i].AddDispetcher);
                    k++;
                }
                if (_buttonSouthEnabled && Accident.AccidentList[i].District == "ЮГ")
                {
                    listView1.Items.Add(Convert.ToString(Accident.AccidentList[i].Adress));
                    listView1.Items[k].SubItems.Add(Accident.AccidentList[i]._Accident);
                    listView1.Items[k].SubItems.Add(Accident.AccidentList[i].TimeAccident);
                    listView1.Items[k].SubItems.Add(Accident.AccidentList[i].AddDispetcher);
                    k++;
                }
                if (_buttonVasEnabled && Accident.AccidentList[i].District == "ЗАО")
                {
                    listView1.Items.Add(Convert.ToString(Accident.AccidentList[i].Adress));
                    listView1.Items[k].SubItems.Add(Accident.AccidentList[i]._Accident);
                    listView1.Items[k].SubItems.Add(Accident.AccidentList[i].TimeAccident);
                    listView1.Items[k].SubItems.Add(Accident.AccidentList[i].AddDispetcher);
                    k++;
                }
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Accident.Transfer = "AddAccident";
            AddAccidentForm newForm = new AddAccidentForm();
            newForm.Show();
        }
        private void button_Edit_Click(object sender, EventArgs e)
        {
            Accident.Transfer = "EditAccident";
            AddAccidentForm newForm = new AddAccidentForm();
            newForm.Show();
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            
        }
        private void timerAccident_Tick(object sender, EventArgs e)
        {
            if (Accident.Transfer == "AddAccident=true")
            {
                ListViewCompleting(sender, e);
                Accident.Transfer = "";
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = "0";
        }
    }
}
