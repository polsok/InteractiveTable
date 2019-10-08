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
    public partial class Form1 : Form
    {
        public delegate void MethodContainer();
        public event MethodContainer onCount;
        public Form1()
        {
            InitializeComponent();
            while (true)
            {
                string[] data = File.ReadAllLines("test.txt");
                Thread.Sleep(1000);
                onCount();
            }
            
        }

        public void count()
        {

        }
    }
}
