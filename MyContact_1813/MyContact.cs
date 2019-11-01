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
    public partial class MyContact : Form
    {
        public MyContact()
        {
            InitializeComponent();
            myContactList1.Show();
        }
        private void LogoutStripMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.loginForm.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void newContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myContactList1.Hide();
            newContact1.Show();
        }
        private void listContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myContactList1.Show();
            newContact1.Hide();
        }
        private void MyContact_SizeChanged(object sender, EventArgs e)
        {
            this.newContact1.Location = new Point(
                this.ClientSize.Width / 2 - newContact1.Size.Width / 2,
                this.ClientSize.Height / 2 - newContact1.Size.Height / 2);
        }
        private void aboutMyContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }
        private void SaveAsTextStripMenu_Click(object sender, EventArgs e)
        {
            myContactList1.SaveAsTexxt();
        }
        public void refresh()
        {
            myContactList1.refreshData();
        }
        public bool checknumb(string numb)
        {
            return myContactList1.checknumb(numb);
        }
    }
}
