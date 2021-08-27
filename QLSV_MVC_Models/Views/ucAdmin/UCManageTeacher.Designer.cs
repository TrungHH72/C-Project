
namespace ProjectQLSV_N12.Views.ucAdmin
{
    partial class UCManageTeacher
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
            this.dgvManageTch = new System.Windows.Forms.DataGridView();
            this.tbHometowntch = new System.Windows.Forms.TextBox();
            this.dtpDateTch = new System.Windows.Forms.DateTimePicker();
            this.btnDelTch = new System.Windows.Forms.Button();
            this.btnEditTch = new System.Windows.Forms.Button();
            this.btnAddTch = new System.Windows.Forms.Button();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.tbFullnameTch = new System.Windows.Forms.TextBox();
            this.tbIdTch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageTch
            // 
            this.dgvManageTch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManageTch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageTch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvManageTch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageTch.Location = new System.Drawing.Point(300, 50);
            this.dgvManageTch.Name = "dgvManageTch";
            this.dgvManageTch.Size = new System.Drawing.Size(360, 300);
            this.dgvManageTch.TabIndex = 23;
            this.dgvManageTch.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvManageTch_CellMouseClick);
            // 
            // tbHometowntch
            // 
            this.tbHometowntch.Location = new System.Drawing.Point(150, 210);
            this.tbHometowntch.Name = "tbHometowntch";
            this.tbHometowntch.Size = new System.Drawing.Size(120, 20);
            this.tbHometowntch.TabIndex = 20;
            // 
            // dtpDateTch
            // 
            this.dtpDateTch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTch.Location = new System.Drawing.Point(150, 170);
            this.dtpDateTch.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtpDateTch.Name = "dtpDateTch";
            this.dtpDateTch.Size = new System.Drawing.Size(120, 20);
            this.dtpDateTch.TabIndex = 19;
            this.dtpDateTch.Value = new System.DateTime(1970, 1, 1, 16, 13, 0, 0);
            // 
            // btnDelTch
            // 
            this.btnDelTch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnDelTch.FlatAppearance.BorderSize = 0;
            this.btnDelTch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelTch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelTch.ForeColor = System.Drawing.Color.White;
            this.btnDelTch.Location = new System.Drawing.Point(40, 316);
            this.btnDelTch.Name = "btnDelTch";
            this.btnDelTch.Size = new System.Drawing.Size(100, 30);
            this.btnDelTch.TabIndex = 24;
            this.btnDelTch.Text = "Xóa";
            this.btnDelTch.UseVisualStyleBackColor = false;
            this.btnDelTch.Click += new System.EventHandler(this.btnDelTch_Click);
            // 
            // btnEditTch
            // 
            this.btnEditTch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnEditTch.FlatAppearance.BorderSize = 0;
            this.btnEditTch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTch.ForeColor = System.Drawing.Color.White;
            this.btnEditTch.Location = new System.Drawing.Point(170, 266);
            this.btnEditTch.Name = "btnEditTch";
            this.btnEditTch.Size = new System.Drawing.Size(100, 30);
            this.btnEditTch.TabIndex = 22;
            this.btnEditTch.Text = "Sửa";
            this.btnEditTch.UseVisualStyleBackColor = false;
            this.btnEditTch.Click += new System.EventHandler(this.btnEditTch_Click);
            // 
            // btnAddTch
            // 
            this.btnAddTch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnAddTch.FlatAppearance.BorderSize = 0;
            this.btnAddTch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTch.ForeColor = System.Drawing.Color.White;
            this.btnAddTch.Location = new System.Drawing.Point(40, 266);
            this.btnAddTch.Name = "btnAddTch";
            this.btnAddTch.Size = new System.Drawing.Size(100, 30);
            this.btnAddTch.TabIndex = 21;
            this.btnAddTch.Text = "Thêm";
            this.btnAddTch.UseVisualStyleBackColor = false;
            this.btnAddTch.Click += new System.EventHandler(this.btnAddTch_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(223, 128);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(47, 24);
            this.rbFemale.TabIndex = 18;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(150, 128);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(60, 24);
            this.rbMale.TabIndex = 17;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // tbFullnameTch
            // 
            this.tbFullnameTch.Location = new System.Drawing.Point(150, 90);
            this.tbFullnameTch.Name = "tbFullnameTch";
            this.tbFullnameTch.Size = new System.Drawing.Size(120, 20);
            this.tbFullnameTch.TabIndex = 16;
            // 
            // tbIdTch
            // 
            this.tbIdTch.Location = new System.Drawing.Point(150, 50);
            this.tbIdTch.Name = "tbIdTch";
            this.tbIdTch.Size = new System.Drawing.Size(120, 20);
            this.tbIdTch.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên giáo viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã giáo viên";
            // 
            // UCManageTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvManageTch);
            this.Controls.Add(this.tbHometowntch);
            this.Controls.Add(this.dtpDateTch);
            this.Controls.Add(this.btnDelTch);
            this.Controls.Add(this.btnEditTch);
            this.Controls.Add(this.btnAddTch);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbFullnameTch);
            this.Controls.Add(this.tbIdTch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "UCManageTeacher";
            this.Size = new System.Drawing.Size(700, 400);
            this.Load += new System.EventHandler(this.UCManageTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManageTch;
        private System.Windows.Forms.TextBox tbHometowntch;
        private System.Windows.Forms.DateTimePicker dtpDateTch;
        private System.Windows.Forms.Button btnDelTch;
        private System.Windows.Forms.Button btnEditTch;
        private System.Windows.Forms.Button btnAddTch;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox tbFullnameTch;
        private System.Windows.Forms.TextBox tbIdTch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
