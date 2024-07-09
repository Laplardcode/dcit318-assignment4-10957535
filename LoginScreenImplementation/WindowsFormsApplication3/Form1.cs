using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreenImplementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            MessageBox.Show($"Username: {username}\nPassword: {password}");
        }
    }
}
