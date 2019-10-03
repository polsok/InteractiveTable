using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Close();
        }
    }
}
