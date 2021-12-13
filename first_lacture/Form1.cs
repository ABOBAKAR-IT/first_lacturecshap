using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_lacture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
