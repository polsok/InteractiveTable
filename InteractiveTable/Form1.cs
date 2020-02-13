using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace InteractiveTable
{
    public partial class Form1 : Form
    {
        private static MyException myException;
        static bool _buttonSouthEnabled = false;
        static bool _buttonNordEnabled = false;
        static bool _buttonVasEnabled = false;
        static bool _buttonGks3Enabled = false;
        public static string Button = "";

        public Form1()
        {
            InitializeComponent();
            CreateHeadersAndFillListView();
            //Accident.Transfer = true;
        }
        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Width = 0;
            colHead.Text = "TimeCreate";
            listViewAccident.Columns.Add(colHead);

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
            try
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
                    default:
                        break;
                }
                listViewAccident.Items.Clear();
                if (AccidentObj.AccidentList == null)
                    return;
                using (AccidentContext db = new AccidentContext())
                {
                    List<string> districtList = new List<string>();
                    if (_buttonGks3Enabled)
                        districtList.Add("ЖКС3");
                    if (_buttonNordEnabled)
                        districtList.Add("СЕВЕР");
                    if (_buttonSouthEnabled)
                        districtList.Add("ЮГ");
                    if (_buttonVasEnabled)
                        districtList.Add("ЗАО");
                    var accidents = AccidentObj.AccidentList.Where(p => districtList.Contains(p.District));
                    for (int i = 0; i < accidents.Count(); i++)
                    {
                        lvi = new ListViewItem();
                        lvi.Text = accidents.ElementAt(i).DataTime;

                        lvsi = new ListViewItem.ListViewSubItem();
                        lvsi.Text = accidents.ElementAt(i).Adress;
                        lvi.SubItems.Add(lvsi);

                        lvsi = new ListViewItem.ListViewSubItem();
                        lvsi.Text = accidents.ElementAt(i).Accident;
                        lvi.SubItems.Add(lvsi);

                        lvsi = new ListViewItem.ListViewSubItem();
                        lvsi.Text = accidents.ElementAt(i).TimeAccident;
                        lvi.SubItems.Add(lvsi);

                        lvsi = new ListViewItem.ListViewSubItem();
                        lvsi.Text = accidents.ElementAt(i).AddDispetcher;
                        lvi.SubItems.Add(lvsi);

                        listViewAccident.Items.Add(lvi);
                    }
                }
            }
            catch (Exception e1)
            {
                myException = new MyException(e1);

            }
                 
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Button = "Add";
            AddAccidentForm newForm = new AddAccidentForm();
            newForm.Show();
        }
        private void button_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = "";
                foreach (ListViewItem item in listViewAccident.SelectedItems)
                {
                    selected = item.Text;
                }

                if (selected == "")
                {
                    MessageBox.Show("Выберете что изменять");
                    return;
                }
                //находим по времени происшествие
                foreach (var var in AccidentObj.AccidentList)
                    if (var.DataTime == selected)
                        AccidentObj.ObjAccident = var;
                Button = "Edit";
                AddAccidentForm newForm = new AddAccidentForm();
                newForm.Show();
            }
            catch (Exception e1)
            {
                myException = new MyException(e1);

            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = "";
                foreach (ListViewItem item in listViewAccident.SelectedItems)
                {
                    selected = item.Text;
                }

                if (selected == "")
                {
                    MessageBox.Show("Выберете что удалять");
                    return;
                }
                //находим по времени происшествие
                AccidentObj obj = new AccidentObj();
                foreach (var var in AccidentObj.AccidentList)
                    if (var.DataTime == selected)
                        obj = var;
                AccidentObj.DeleteAccident(obj);
            }
            catch (Exception e1)
            {
                myException = new MyException(e1);
            }

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval = 10000;
                List<AccidentObj> AccidentList = new List<AccidentObj>();
                using (AccidentContext db = new AccidentContext())
                {
                    var kinds = new[] {"Удален", "Изменен"};
                    var accidents = db.Accidents.Where(p => !kinds.Contains(p.Kind));
                    foreach (var VARIABLE in accidents)
                    {
                        AccidentList.Add(VARIABLE);
                    }
                }               
                if (!AccidentObj.GetHash(AccidentList, AccidentObj.AccidentList))
                {
                    AccidentObj.AccidentList = AccidentList.GetRange(0, AccidentList.Count);
                    ListViewCompleting(sender, e);
                }
            }
            catch (Exception e1)
            {
                myException = new MyException(e1);
            }
            
        }

        private void buttonStory_Click(object sender, EventArgs e)
        {
            StoryForm storyForm = new StoryForm();
            storyForm.Show();
        }
    }
}
