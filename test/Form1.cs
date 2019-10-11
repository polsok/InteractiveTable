using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace test
{
    public delegate void UI();
    public partial class Form1 : Form
    {
        // Объявляем событие
        //public static event UI UserEvent;

        // Используем метод для запуска события
        public static void OnUserEvent()
        {
            //UserEvent();
        }
        public Form1()
        {
            
            InitializeComponent();
            // Добавляем обработчик события
            /*UserEvent += UserInfoHandler;
            while (true)
            {
            
            Thread.Sleep(1000);
                // Запустим событие
                OnUserEvent();
            }*/
            
            
        }
       /* public void UserInfoHandler()
        {
            textBox1.Text = File.ReadAllText("test.txt");
        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText("test.txt");
        }
    }
}
