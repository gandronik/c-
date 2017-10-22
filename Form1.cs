using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string usr = "George";
        string pw = "takis1";
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == usr)
            {
                if (textBox2.Text == pw)
                {
                    MessageBox.Show("Hello " + usr + "!");
                    return;
                }
                else
                {
                    MessageBox.Show("Wrong username/password!");
                }
            }
            else MessageBox.Show("Wrong username/password!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
