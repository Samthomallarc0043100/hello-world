using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello_world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("goodbye " + txtBxName.Text);
            MessageBox.Show("welcome to " + txtBxName.Text + "'s program");
            MessageBox.Show("hello"+ txtBxName.Text + "and" + txtBxName2.Text);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


