using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyContact_1813
{
    public partial class MyContactList : UserControl
    {
        public MyContactList()
        {
            InitializeComponent();
            lblUsername.Text = "Admin";
            lblTotalContact.Text = "0";
        }
        public bool checknumb(string numb)
        {
            int baris = 0;
            baris = dgvContactList.Rows.Count - 2;
            for (int i = 0; i < baris + 1; i++)
            {
                if (numb == dgvContactList[2, i].Value.ToString())
                {
                    MessageBox.Show("This number is already saved!\n Try Again");
                    return false;
                }
            }
            return true;
        }
        public void refreshData()
        {
            int baris = 0;
            dgvContactList.Rows.Add();
            baris = dgvContactList.Rows.Count - 2;
            dgvContactList[0, baris].Value = List.nama;
            dgvContactList[1, baris].Value = List.jeniskelamin;
            dgvContactList[2, baris].Value = List.telepon;
            dgvContactList[3, baris].Value = List.alamat;
            dgvContactList.Sort(dgvContactList.Columns[0], ListSortDirection.Ascending);
            lblTotalContact.Text = (dgvContactList.Rows.Count - 1).ToString();
        }
        public void SaveAsTexxt()
        {
            using (TextWriter tw = new StreamWriter("ContactList.txt"))
            {
                for (int i = 0; i < dgvContactList.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvContactList.Columns.Count; j++)
                    {
                        tw.Write($"{dgvContactList.Rows[i].Cells[j].Value.ToString()}");

                        if (j != dgvContactList.Columns.Count - 1)
                        {
                            tw.Write(",");
                        }
                    }
                    tw.WriteLine();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvContactList.SelectedRows.Count > 0)
            {
                dgvContactList.Rows.RemoveAt(this.dgvContactList.SelectedRows[0].Index);
            }
        }
    }
}
