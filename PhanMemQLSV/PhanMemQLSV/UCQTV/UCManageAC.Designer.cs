
namespace PhanMemQLSV.UCQTV
{
    partial class UCManageAC
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
            this.lbTypeAccount = new System.Windows.Forms.Label();
            this.cbbTypeAccount = new System.Windows.Forms.ComboBox();
            this.lbIdUs = new System.Windows.Forms.Label();
            this.cbbIdUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdAccount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTypeAccount
            // 
            this.lbTypeAccount.AutoSize = true;
            this.lbTypeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeAccount.Location = new System.Drawing.Point(40, 50);
            this.lbTypeAccount.Name = "lbTypeAccount";
            this.lbTypeAccount.Size = new System.Drawing.Size(108, 20);
            this.lbTypeAccount.TabIndex = 0;
            this.lbTypeAccount.Text = "Loại tài khoản";
            // 
            // cbbTypeAccount
            // 
            this.cbbTypeAccount.FormattingEnabled = true;
            this.cbbTypeAccount.Items.AddRange(new object[] {
            "giáo viên",
            "sinh viên"});
            this.cbbTypeAccount.Location = new System.Drawing.Point(162, 50);
            this.cbbTypeAccount.Name = "cbbTypeAccount";
            this.cbbTypeAccount.Size = new System.Drawing.Size(145, 21);
            this.cbbTypeAccount.TabIndex = 1;
            this.cbbTypeAccount.SelectedIndexChanged += new System.EventHandler(this.cbbTypeAccount_SelectedIndexChanged);
            // 
            // lbIdUs
            // 
            this.lbIdUs.AutoSize = true;
            this.lbIdUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdUs.Location = new System.Drawing.Point(40, 130);
            this.lbIdUs.Name = "lbIdUs";
            this.lbIdUs.Size = new System.Drawing.Size(97, 20);
            this.lbIdUs.TabIndex = 0;
            this.lbIdUs.Text = "Mã giáo viên";
            // 
            // cbbIdUser
            // 
            this.cbbIdUser.FormattingEnabled = true;
            this.cbbIdUser.Location = new System.Drawing.Point(162, 130);
            this.cbbIdUser.Name = "cbbIdUser";
            this.cbbIdUser.Size = new System.Drawing.Size(145, 21);
            this.cbbIdUser.TabIndex = 3;
            this.cbbIdUser.SelectedIndexChanged += new System.EventHandler(this.cbbIdUser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(162, 170);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(145, 21);
            this.tbUsername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(162, 210);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(145, 21);
            this.tbPassword.TabIndex = 5;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(44, 267);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(130, 40);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Tạo tài khoản";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(335, 50);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.Size = new System.Drawing.Size(325, 300);
            this.dgvAccount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã tài khoản";
            // 
            // tbIdAccount
            // 
            this.tbIdAccount.Location = new System.Drawing.Point(162, 90);
            this.tbIdAccount.Multiline = true;
            this.tbIdAccount.Name = "tbIdAccount";
            this.tbIdAccount.Size = new System.Drawing.Size(145, 21);
            this.tbIdAccount.TabIndex = 2;
            // 
            // UCManageAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbIdAccount);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbIdUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbIdUs);
            this.Controls.Add(this.cbbTypeAccount);
            this.Controls.Add(this.lbTypeAccount);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "UCManageAC";
            this.Size = new System.Drawing.Size(700, 400);
            this.Load += new System.EventHandler(this.UCManageAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTypeAccount;
        private System.Windows.Forms.ComboBox cbbTypeAccount;
        private System.Windows.Forms.Label lbIdUs;
        private System.Windows.Forms.ComboBox cbbIdUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdAccount;
    }
}
