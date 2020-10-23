using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegisterPhones
{
    public partial class StoryForm : Form
    {
        private static MyException myException;
        private static List<PhoneObj> AccidentHistoryList;
        public StoryForm()
        {
            InitializeComponent();
            try
            {
                AccidentHistoryList = new List<PhoneObj>();
                using (AccidentContext db = new AccidentContext())
                {
                    var accidents = db.Accidents;
                    foreach (var VARIABLE in accidents)
                    {
                        AccidentHistoryList.Add(VARIABLE);
                    }
                }                
            }
            catch (Exception e1)
            {
                myException = new MyException(e1);
            }
            CreateHeadersAndFillListView();
        }

        private void CreateHeadersAndFillListView()
        {
            try
            {
                ColumnHeader colHead;
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                colHead = new ColumnHeader();
                colHead.Width = 130;
                colHead.Text = "TimeCreate";
                listViewAccident.Columns.Add(colHead);

                colHead = new ColumnHeader();
                colHead.Width = 150;
                colHead.Text = "Адрес";
                listViewAccident.Columns.Add(colHead);

                colHead = new ColumnHeader();
                colHead.Width = 250;
                colHead.Text = "Происшествие";
                listViewAccident.Columns.Add(colHead);

                colHead = new ColumnHeader();
                colHead.Width = 87;
                colHead.Text = "Время работ";
                listViewAccident.Columns.Add(colHead);

                colHead = new ColumnHeader();
                colHead.Width = 100;
                colHead.Text = "Добавил";
                listViewAccident.Columns.Add(colHead);

                colHead = new ColumnHeader();
                colHead.Width = 100;
                colHead.Text = "Удалил";
                listViewAccident.Columns.Add(colHead);

                colHead = new ColumnHeader();
                colHead.Width = 80;
                colHead.Text = "Район";
                listViewAccident.Columns.Add(colHead);

                colHead = new ColumnHeader();
                colHead.Width = 100;
                colHead.Text = "Имя компьютера";
                listViewAccident.Columns.Add(colHead);
                colHead = new ColumnHeader();
                colHead.Width = 80;
                colHead.Text = "Тип";
                listViewAccident.Columns.Add(colHead);
                for (int i = 0; i < AccidentHistoryList.Count; i++)
                {
                    lvi = new ListViewItem();
                    lvi.Text = AccidentHistoryList[i].DataTime;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = AccidentHistoryList[i].Street;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = AccidentHistoryList[i].Accident;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = AccidentHistoryList[i].DateCall;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = AccidentHistoryList[i].AddDispetcher;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = AccidentHistoryList[i].RemoveDispetcher;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = AccidentHistoryList[i].District;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = AccidentHistoryList[i].Computer;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = AccidentHistoryList[i].Kind;
                    lvi.SubItems.Add(lvsi);

                    listViewAccident.Items.Add(lvi);
                }
            }
            catch (Exception e1)
            {
                myException = new MyException(e1);
            }           
        }
    }
}
