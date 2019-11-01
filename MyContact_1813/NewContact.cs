using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContact_1813
{
    public partial class NewContact : UserControl
    {
        public NewContact()
        {
            InitializeComponent();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string jk;
            if (rBLaki.Checked == true)
            {
                jk = "Laki-laki";
            } else if(rBPerempuan.Checked == true)
            {
                jk = "Perempuan";
            } else { jk = ""; }
            if (LoginForm.mycontact.checknumb(txtBoxTelepon.Text) == true)
            {
                List.nama = txtBoxName.Text;
                List.jeniskelamin = jk;
                List.telepon = txtBoxTelepon.Text;
                List.alamat = rtbAlamat.Text;
                MessageBox.Show("No " + List.telepon + " telah ditambahkan");
                LoginForm.mycontact.refresh();
                txtBoxName.Text = "";
                txtBoxTelepon.Text = "";
                rBLaki.Checked = false;
                rBPerempuan.Checked = false;
                rtbAlamat.Text = "";
            }
        }
    }
}
