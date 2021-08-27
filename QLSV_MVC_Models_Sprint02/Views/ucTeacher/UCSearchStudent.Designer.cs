
namespace ProjectQLSV_N12.Views.ucTeacher
{
    partial class UCSearchStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbIdClass = new System.Windows.Forms.ComboBox();
            this.dgvListStd = new System.Windows.Forms.DataGridView();
            this.dgvRsStudy = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdStd = new System.Windows.Forms.TextBox();
            this.tbNameStd = new System.Windows.Forms.MaskedTextBox();
            this.tbNameClass = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRsStudy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // cbbIdClass
            // 
            this.cbbIdClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbIdClass.FormattingEnabled = true;
            this.cbbIdClass.Location = new System.Drawing.Point(85, 30);
            this.cbbIdClass.Name = "cbbIdClass";
            this.cbbIdClass.Size = new System.Drawing.Size(121, 21);
            this.cbbIdClass.TabIndex = 1;
            this.cbbIdClass.SelectedIndexChanged += new System.EventHandler(this.cbbIdClass_SelectedIndexChanged);
            // 
            // dgvListStd
            // 
            this.dgvListStd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListStd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStd.Location = new System.Drawing.Point(40, 80);
            this.dgvListStd.Name = "dgvListStd";
            this.dgvListStd.Size = new System.Drawing.Size(290, 290);
            this.dgvListStd.TabIndex = 2;
            this.dgvListStd.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListStd_CellMouseClick);
            // 
            // dgvRsStudy
            // 
            this.dgvRsStudy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRsStudy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRsStudy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRsStudy.Location = new System.Drawing.Point(370, 190);
            this.dgvRsStudy.Name = "dgvRsStudy";
            this.dgvRsStudy.Size = new System.Drawing.Size(290, 180);
            this.dgvRsStudy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sinh viên";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên lớp";
            // 
            // tbIdStd
            // 
            this.tbIdStd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIdStd.Location = new System.Drawing.Point(451, 30);
            this.tbIdStd.Name = "tbIdStd";
            this.tbIdStd.Size = new System.Drawing.Size(155, 20);
            this.tbIdStd.TabIndex = 3;
            // 
            // tbNameStd
            // 
            this.tbNameStd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameStd.Location = new System.Drawing.Point(451, 66);
            this.tbNameStd.Name = "tbNameStd";
            this.tbNameStd.Size = new System.Drawing.Size(155, 20);
            this.tbNameStd.TabIndex = 4;
            // 
            // tbNameClass
            // 
            this.tbNameClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameClass.Location = new System.Drawing.Point(451, 102);
            this.tbNameClass.Name = "tbNameClass";
            this.tbNameClass.Size = new System.Drawing.Size(155, 20);
            this.tbNameClass.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(367, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bảng điểm";
            // 
            // UCSearchStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNameClass);
            this.Controls.Add(this.tbNameStd);
            this.Controls.Add(this.tbIdStd);
            this.Controls.Add(this.dgvRsStudy);
            this.Controls.Add(this.dgvListStd);
            this.Controls.Add(this.cbbIdClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "UCSearchStudent";
            this.Size = new System.Drawing.Size(700, 400);
            this.Load += new System.EventHandler(this.UCSearchStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRsStudy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbIdClass;
        private System.Windows.Forms.DataGridView dgvListStd;
        private System.Windows.Forms.DataGridView dgvRsStudy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdStd;
        private System.Windows.Forms.MaskedTextBox tbNameStd;
        private System.Windows.Forms.MaskedTextBox tbNameClass;
        private System.Windows.Forms.Label label5;
    }
}
