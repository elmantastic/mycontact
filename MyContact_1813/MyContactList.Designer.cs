namespace MyContact_1813
{
    partial class MyContactList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telepon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.lblTotalContact = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContactList
            // 
            this.dgvContactList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.JK,
            this.Telepon,
            this.Address});
            this.dgvContactList.Location = new System.Drawing.Point(0, 37);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.Size = new System.Drawing.Size(615, 186);
            this.dgvContactList.TabIndex = 0;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Name";
            this.Nama.Name = "Nama";
            this.Nama.Width = 130;
            // 
            // JK
            // 
            this.JK.HeaderText = "Gender";
            this.JK.Name = "JK";
            this.JK.Width = 80;
            // 
            // Telepon
            // 
            this.Telepon.HeaderText = "Telephone";
            this.Telepon.Name = "Telepon";
            this.Telepon.Width = 120;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 245;
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(338, 7);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(93, 16);
            this.Total.TabIndex = 1;
            this.Total.Text = "Total Contact :";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(21, 7);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(43, 16);
            this.User.TabIndex = 3;
            this.User.Text = "User :";
            // 
            // lblTotalContact
            // 
            this.lblTotalContact.AutoSize = true;
            this.lblTotalContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalContact.Location = new System.Drawing.Point(563, 7);
            this.lblTotalContact.Name = "lblTotalContact";
            this.lblTotalContact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalContact.Size = new System.Drawing.Size(15, 16);
            this.lblTotalContact.TabIndex = 4;
            this.lblTotalContact.Text = "0";
            this.lblTotalContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(512, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(70, 7);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(0, 16);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MyContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTotalContact);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.dgvContactList);
            this.Name = "MyContactList";
            this.Size = new System.Drawing.Size(615, 279);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label lblTotalContact;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn JK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telepon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Label lblUsername;
    }
}
