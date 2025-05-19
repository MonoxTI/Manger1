using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manger1
{
    public partial class Form1 : Form
    {
        DataHandler handler = new DataHandler();
        public Form1()
        {
            InitializeComponent();
            DataGridView.DataSource = AddingNewEventHandler.getproperty();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
