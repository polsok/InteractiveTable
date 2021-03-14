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
        static bool _buttonElevEnabled = false;
        static bool _buttonInfoEnabled = false;
        public static string Button = "";
        private static string SizeFont = "";


        public Form1()
        {
            InitializeComponent();
            CreateHeadersAndFillListView();
            CreateContextMenu();
        }

        #region ContextMenu

        public void CreateContextMenu()
        {
            // создаем элементы меню
            ToolStripMenuItem IncreaseFont = new ToolStripMenuItem("Увеличить шрифт");
            ToolStripMenuItem ReduceFont = new ToolStripMenuItem("Уменьшить шрифт");
            // добавляем элементы в меню
            contextMenuStrip1.Items.AddRange(new[] { IncreaseFont, ReduceFont });
            // ассоциируем контекстное меню с текстовым полем
            listViewAccident.ContextMenuStrip = contextMenuStrip1;
            // устанавливаем обработчики событий для меню
            IncreaseFont.Click += IncreaseFont_Click;
            ReduceFont.Click += ReduceFont_Click;
        }
        // Увеличение шрифта
        void IncreaseFont_Click(object sender, EventArgs e)
        {
            SizeFont = "Increase";
        }
        // Уменьшение шрифта
        void ReduceFont_Click(object sender, EventArgs e)
        {
            SizeFont = "Reduce";
        }

        internal static void ChangeFont(ListViewItem lvi)
        {
            if (SizeFont == "Increase")
            {
                float currentSize = lvi.Font.Size;
                currentSize += 0.5F;
                lvi.Font = new Font(lvi.Font.Name, currentSize, lvi.Font.Style);
            }
            if (SizeFont == "Reduce")
            {
                float currentSize = lvi.Font.Size;
                currentSize -= 1.0F;
                lvi.Font = new Font(lvi.Font.Name, currentSize, lvi.Font.Style);
            }
        }
        #endregion
        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Width = 0;
            colHead.Text = "TimeCreate";
            listViewAccident.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 180;
            colHead.Text = "Адрес";
            listViewAccident.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 370;
            colHead.Text = "Происшествие";
            listViewAccident.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 120;
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
                    case "System.Windows.Forms.Button, Text: ЛИФТЫ":
                        if (_buttonElevEnabled)
                        {
                            button_Elev.BackColor = System.Drawing.Color.White;
                            _buttonElevEnabled = false;
                        }
                        else
                        {
                            button_Elev.BackColor = System.Drawing.Color.DarkOrange;
                            _buttonElevEnabled = true;
                        }
                        break;
                    case "System.Windows.Forms.Button, Text: ИНФО":
                        if (_buttonInfoEnabled)
                        {
                            button_Info.BackColor = System.Drawing.Color.White;
                            _buttonInfoEnabled = false;
                        }
                        else
                        {
                            button_Info.BackColor = System.Drawing.Color.Pink;
                            _buttonInfoEnabled = true;
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
                    if (_buttonElevEnabled)
                        districtList.Add("ЛИФТЫ");
                    if (_buttonInfoEnabled)
                        districtList.Add("ИНФО");
                    var accidents = AccidentObj.AccidentList.Where(p => districtList.Contains(p.District));
                    for (int i = 0; i < accidents.Count(); i++)
                    {
                        lvi = new ListViewItem();
                        ChangeFont(lvi);
                        lvi.Text = accidents.ElementAt(i).DataTime;

                        lvsi = new ListViewItem.ListViewSubItem();
                        ChangeFont(lvi);
                        lvsi.Text = accidents.ElementAt(i).Adress;
                        lvi.SubItems.Add(lvsi);

                        lvsi = new ListViewItem.ListViewSubItem();
                        ChangeFont(lvi);
                        lvsi.Text = accidents.ElementAt(i).Accident;
                        lvi.SubItems.Add(lvsi);

                        lvsi = new ListViewItem.ListViewSubItem();
                        ChangeFont(lvi);
                        lvsi.Text = accidents.ElementAt(i).TimeAccident;
                        lvi.SubItems.Add(lvsi);

                        lvsi = new ListViewItem.ListViewSubItem();
                        ChangeFont(lvi);
                        lvsi.Text = accidents.ElementAt(i).AddDispetcher;
                        lvi.SubItems.Add(lvsi);

                        listViewAccident.Items.Add(lvi);
                    }
                    SizeFont = "";
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

                if (SizeFont != "")
                {
                    AccidentObj.AccidentList = AccidentList.GetRange(0, AccidentList.Count);
                    ListViewCompleting(sender, e);
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
