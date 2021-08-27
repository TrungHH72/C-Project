
namespace ProjectQLSV_N12.Views.ucAdmin
{
    partial class UCManageStudent
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
            this.btnDelStd = new System.Windows.Forms.Button();
            this.btnEditStd = new System.Windows.Forms.Button();
            this.btnAddStd = new System.Windows.Forms.Button();
            this.dgvManageStd = new System.Windows.Forms.DataGridView();
            this.cbbIdClass = new System.Windows.Forms.ComboBox();
            this.tbHometownStd = new System.Windows.Forms.TextBox();
            this.dtpDateStd = new System.Windows.Forms.DateTimePicker();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.tbFullnameStd = new System.Windows.Forms.TextBox();
            this.tbIdStd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageStd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelStd
            // 
            this.btnDelStd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnDelStd.FlatAppearance.BorderSize = 0;
            this.btnDelStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStd.ForeColor = System.Drawing.Color.White;
            this.btnDelStd.Location = new System.Drawing.Point(52, 361);
            this.btnDelStd.Name = "btnDelStd";
            this.btnDelStd.Size = new System.Drawing.Size(100, 30);
            this.btnDelStd.TabIndex = 28;
            this.btnDelStd.Text = "Xóa";
            this.btnDelStd.UseVisualStyleBackColor = false;
            this.btnDelStd.Click += new System.EventHandler(this.btnDelStd_Click);
            // 
            // btnEditStd
            // 
            this.btnEditStd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnEditStd.FlatAppearance.BorderSize = 0;
            this.btnEditStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStd.ForeColor = System.Drawing.Color.White;
            this.btnEditStd.Location = new System.Drawing.Point(182, 314);
            this.btnEditStd.Name = "btnEditStd";
            this.btnEditStd.Size = new System.Drawing.Size(100, 30);
            this.btnEditStd.TabIndex = 27;
            this.btnEditStd.Text = "Sửa";
            this.btnEditStd.UseVisualStyleBackColor = false;
            this.btnEditStd.Click += new System.EventHandler(this.btnEditStd_Click);
            // 
            // btnAddStd
            // 
            this.btnAddStd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnAddStd.FlatAppearance.BorderSize = 0;
            this.btnAddStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStd.ForeColor = System.Drawing.Color.White;
            this.btnAddStd.Location = new System.Drawing.Point(52, 316);
            this.btnAddStd.Name = "btnAddStd";
            this.btnAddStd.Size = new System.Drawing.Size(100, 30);
            this.btnAddStd.TabIndex = 26;
            this.btnAddStd.Text = "Thêm";
            this.btnAddStd.UseVisualStyleBackColor = false;
            this.btnAddStd.Click += new System.EventHandler(this.btnAddStd_Click);
            // 
            // dgvManageStd
            // 
            this.dgvManageStd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManageStd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageStd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvManageStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageStd.Location = new System.Drawing.Point(312, 71);
            this.dgvManageStd.Name = "dgvManageStd";
            this.dgvManageStd.ReadOnly = true;
            this.dgvManageStd.Size = new System.Drawing.Size(360, 300);
            this.dgvManageStd.TabIndex = 25;
            this.dgvManageStd.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvManageStd_CellMouseClick);
            // 
            // cbbIdClass
            // 
            this.cbbIdClass.FormattingEnabled = true;
            this.cbbIdClass.Location = new System.Drawing.Point(162, 271);
            this.cbbIdClass.Name = "cbbIdClass";
            this.cbbIdClass.Size = new System.Drawing.Size(120, 21);
            this.cbbIdClass.TabIndex = 24;
            // 
            // tbHometownStd
            // 
            this.tbHometownStd.Location = new System.Drawing.Point(162, 231);
            this.tbHometownStd.Name = "tbHometownStd";
            this.tbHometownStd.Size = new System.Drawing.Size(120, 20);
            this.tbHometownStd.TabIndex = 23;
            // 
            // dtpDateStd
            // 
            this.dtpDateStd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStd.Location = new System.Drawing.Point(162, 191);
            this.dtpDateStd.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDateStd.Name = "dtpDateStd";
            this.dtpDateStd.Size = new System.Drawing.Size(120, 20);
            this.dtpDateStd.TabIndex = 22;
            this.dtpDateStd.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(235, 149);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(47, 24);
            this.rbFemale.TabIndex = 21;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(162, 149);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(60, 24);
            this.rbMale.TabIndex = 20;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // tbFullnameStd
            // 
            this.tbFullnameStd.Location = new System.Drawing.Point(162, 111);
            this.tbFullnameStd.Name = "tbFullnameStd";
            this.tbFullnameStd.Size = new System.Drawing.Size(120, 20);
            this.tbFullnameStd.TabIndex = 19;
            // 
            // tbIdStd
            // 
            this.tbIdStd.Location = new System.Drawing.Point(162, 71);
            this.tbIdStd.Name = "tbIdStd";
            this.tbIdStd.Size = new System.Drawing.Size(120, 20);
            this.tbIdStd.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã sinh viên";
            // 
            // UCManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelStd);
            this.Controls.Add(this.btnEditStd);
            this.Controls.Add(this.btnAddStd);
            this.Controls.Add(this.dgvManageStd);
            this.Controls.Add(this.cbbIdClass);
            this.Controls.Add(this.tbHometownStd);
            this.Controls.Add(this.dtpDateStd);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbFullnameStd);
            this.Controls.Add(this.tbIdStd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "UCManageStudent";
            this.Size = new System.Drawing.Size(725, 463);
            this.Load += new System.EventHandler(this.UCManageStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageStd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelStd;
        private System.Windows.Forms.Button btnEditStd;
        private System.Windows.Forms.Button btnAddStd;
        private System.Windows.Forms.DataGridView dgvManageStd;
        private System.Windows.Forms.ComboBox cbbIdClass;
        private System.Windows.Forms.TextBox tbHometownStd;
        private System.Windows.Forms.DateTimePicker dtpDateStd;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox tbFullnameStd;
        private System.Windows.Forms.TextBox tbIdStd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
