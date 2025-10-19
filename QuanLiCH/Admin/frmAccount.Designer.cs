namespace QuanLiCH.Admin
{
    partial class frmAccount
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgAccount = new System.Windows.Forms.DataGridView();
            this.btnreEnterPass = new System.Windows.Forms.Button();
            this.panel28 = new System.Windows.Forms.Panel();
            this.nmTypeAccount = new System.Windows.Forms.NumericUpDown();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lbIdAccout = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnDelteteAccout = new System.Windows.Forms.Button();
            this.btnUpdateAccout = new System.Windows.Forms.Button();
            this.btnAddAccout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).BeginInit();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTypeAccount)).BeginInit();
            this.panel27.SuspendLayout();
            this.panel26.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgAccount
            // 
            this.dtgAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAccount.Location = new System.Drawing.Point(19, 202);
            this.dtgAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgAccount.Name = "dtgAccount";
            this.dtgAccount.RowHeadersWidth = 51;
            this.dtgAccount.Size = new System.Drawing.Size(1013, 271);
            this.dtgAccount.TabIndex = 1;
            // 
            // btnreEnterPass
            // 
            this.btnreEnterPass.BackColor = System.Drawing.Color.Honeydew;
            this.btnreEnterPass.Location = new System.Drawing.Point(544, 128);
            this.btnreEnterPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreEnterPass.Name = "btnreEnterPass";
            this.btnreEnterPass.Size = new System.Drawing.Size(125, 66);
            this.btnreEnterPass.TabIndex = 7;
            this.btnreEnterPass.Text = "Đặt Lại Mật Khẩu:";
            this.btnreEnterPass.UseVisualStyleBackColor = false;
            this.btnreEnterPass.Click += new System.EventHandler(this.btnreEnterPass_Click);
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.nmTypeAccount);
            this.panel28.Controls.Add(this.lbAccountType);
            this.panel28.Location = new System.Drawing.Point(22, 134);
            this.panel28.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(404, 50);
            this.panel28.TabIndex = 6;
            // 
            // nmTypeAccount
            // 
            this.nmTypeAccount.Location = new System.Drawing.Point(216, 17);
            this.nmTypeAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmTypeAccount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmTypeAccount.Name = "nmTypeAccount";
            this.nmTypeAccount.Size = new System.Drawing.Size(69, 22);
            this.nmTypeAccount.TabIndex = 1;
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountType.Location = new System.Drawing.Point(8, 22);
            this.lbAccountType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(159, 24);
            this.lbAccountType.TabIndex = 0;
            this.lbAccountType.Text = "Loại Tài Khoản:";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.txbDisplayName);
            this.panel27.Controls.Add(this.lbAccountName);
            this.panel27.Location = new System.Drawing.Point(19, 53);
            this.panel27.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(407, 52);
            this.panel27.TabIndex = 5;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(183, 23);
            this.txbDisplayName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(207, 22);
            this.txbDisplayName.TabIndex = 1;
            this.txbDisplayName.TextChanged += new System.EventHandler(this.txbDisplayName_TextChanged);
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountName.Location = new System.Drawing.Point(28, 25);
            this.lbAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(137, 24);
            this.lbAccountName.TabIndex = 0;
            this.lbAccountName.Text = "Tên Hiển Thị:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txbUserName);
            this.panel26.Controls.Add(this.lbIdAccout);
            this.panel26.Location = new System.Drawing.Point(544, 50);
            this.panel26.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(404, 52);
            this.panel26.TabIndex = 4;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(180, 21);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(208, 22);
            this.txbUserName.TabIndex = 1;
            // 
            // lbIdAccout
            // 
            this.lbIdAccout.AutoSize = true;
            this.lbIdAccout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdAccout.Location = new System.Drawing.Point(4, 20);
            this.lbIdAccout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdAccout.Name = "lbIdAccout";
            this.lbIdAccout.Size = new System.Drawing.Size(155, 24);
            this.lbIdAccout.TabIndex = 0;
            this.lbIdAccout.Text = "Tên Tài Khoản:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(422, 10);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(158, 39);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "Tài Khoản";
            // 
            // btnDelteteAccout
            // 
            this.btnDelteteAccout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelteteAccout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelteteAccout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelteteAccout.Location = new System.Drawing.Point(460, 481);
            this.btnDelteteAccout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelteteAccout.Name = "btnDelteteAccout";
            this.btnDelteteAccout.Size = new System.Drawing.Size(103, 42);
            this.btnDelteteAccout.TabIndex = 1;
            this.btnDelteteAccout.Text = "Delete";
            this.btnDelteteAccout.UseVisualStyleBackColor = false;
            // 
            // btnUpdateAccout
            // 
            this.btnUpdateAccout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdateAccout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAccout.Location = new System.Drawing.Point(268, 481);
            this.btnUpdateAccout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateAccout.Name = "btnUpdateAccout";
            this.btnUpdateAccout.Size = new System.Drawing.Size(112, 42);
            this.btnUpdateAccout.TabIndex = 1;
            this.btnUpdateAccout.Text = "Update";
            this.btnUpdateAccout.UseVisualStyleBackColor = false;
            // 
            // btnAddAccout
            // 
            this.btnAddAccout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddAccout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAccout.Location = new System.Drawing.Point(84, 481);
            this.btnAddAccout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAccout.Name = "btnAddAccout";
            this.btnAddAccout.Size = new System.Drawing.Size(105, 42);
            this.btnAddAccout.TabIndex = 1;
            this.btnAddAccout.Text = "Add";
            this.btnAddAccout.UseVisualStyleBackColor = false;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 580);
            this.Controls.Add(this.panel27);
            this.Controls.Add(this.panel28);
            this.Controls.Add(this.btnreEnterPass);
            this.Controls.Add(this.btnDelteteAccout);
            this.Controls.Add(this.btnUpdateAccout);
            this.Controls.Add(this.btnAddAccout);
            this.Controls.Add(this.panel26);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dtgAccount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAccount";
            this.Text = "frmAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).EndInit();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTypeAccount)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAccount;
        private System.Windows.Forms.Button btnreEnterPass;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.NumericUpDown nmTypeAccount;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lbIdAccout;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnAddAccout;
        private System.Windows.Forms.Button btnUpdateAccout;
        private System.Windows.Forms.Button btnDelteteAccout;
    }
}