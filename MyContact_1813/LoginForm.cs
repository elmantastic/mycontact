using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContact_1813
{
    public partial class LoginForm : Form
    {
        public static MyContact mycontact = new MyContact();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_SizeChanged(object sender, EventArgs e)
        {
            this.pLogin.Location = new Point(
                this.ClientSize.Width / 2 - pLogin.Size.Width / 2,
                this.ClientSize.Height / 2 - pLogin.Size.Height / 2);
            // ukuran layar windows/2 dikurangi ukuran panel/2
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtBoxUsername.Text == "admin" && txtBoxPassword.Text == "admin")
            {
                this.Hide();
                
                mycontact.Show();
                txtBoxUsername.Text = "";
                txtBoxPassword.Text = "";
            } else
            {
                MessageBox.Show("Username or Password is incorrect!");
                txtBoxUsername.Text = "";
                txtBoxPassword.Text = "";
            }
        }
    }
}
