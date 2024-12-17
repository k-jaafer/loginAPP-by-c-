using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string validUsername = "admin";
            string validPassword = "password123";

                
            string inputUsername = textBox1.Text;
            string inputPassword = textBox2.Text;

                
            if (inputUsername == validUsername && inputPassword == validPassword)
            {
                labelMessage.Text = "Login Successful";
                labelMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelMessage.Text = "sorry Username or Password Invalid.";
                labelMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
