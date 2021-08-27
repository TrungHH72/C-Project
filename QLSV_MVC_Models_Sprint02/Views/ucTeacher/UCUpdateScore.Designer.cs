
namespace ProjectQLSV_N12.Views.ucTeacher
{
    partial class UCUpdateScore
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbIdClass = new System.Windows.Forms.ComboBox();
            this.tbNameSubject = new System.Windows.Forms.TextBox();
            this.tbNameStudent = new System.Windows.Forms.TextBox();
            this.tbScore2 = new System.Windows.Forms.TextBox();
            this.tbScore1 = new System.Windows.Forms.TextBox();
            this.btnUpdateScore = new System.Windows.Forms.Button();
            this.dgvUpdateScore = new System.Windows.Forms.DataGridView();
            this.tbIdStd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp học";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên môn học";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên sinh viên";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm quá trình";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điểm thi";
            // 
            // cbbIdClass
            // 
            this.cbbIdClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbbIdClass.FormattingEnabled = true;
            this.cbbIdClass.Location = new System.Drawing.Point(110, 30);
            this.cbbIdClass.Name = "cbbIdClass";
            this.cbbIdClass.Size = new System.Drawing.Size(121, 21);
            this.cbbIdClass.TabIndex = 1;
            this.cbbIdClass.SelectedIndexChanged += new System.EventHandler(this.cbbIdClass_SelectedIndexChanged);
            // 
            // tbNameSubject
            // 
            this.tbNameSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbNameSubject.Location = new System.Drawing.Point(326, 31);
            this.tbNameSubject.Name = "tbNameSubject";
            this.tbNameSubject.ReadOnly = true;
            this.tbNameSubject.Size = new System.Drawing.Size(121, 20);
            this.tbNameSubject.TabIndex = 3;
            // 
            // tbNameStudent
            // 
            this.tbNameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbNameStudent.Location = new System.Drawing.Point(326, 70);
            this.tbNameStudent.Name = "tbNameStudent";
            this.tbNameStudent.Size = new System.Drawing.Size(121, 20);
            this.tbNameStudent.TabIndex = 4;
            // 
            // tbScore2
            // 
            this.tbScore2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbScore2.Location = new System.Drawing.Point(558, 70);
            this.tbScore2.Name = "tbScore2";
            this.tbScore2.Size = new System.Drawing.Size(102, 20);
            this.tbScore2.TabIndex = 6;
            // 
            // tbScore1
            // 
            this.tbScore1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbScore1.Location = new System.Drawing.Point(558, 30);
            this.tbScore1.Name = "tbScore1";
            this.tbScore1.Size = new System.Drawing.Size(102, 20);
            this.tbScore1.TabIndex = 5;
            // 
            // btnUpdateScore
            // 
            this.btnUpdateScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnUpdateScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateScore.FlatAppearance.BorderSize = 0;
            this.btnUpdateScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateScore.ForeColor = System.Drawing.Color.White;
            this.btnUpdateScore.Location = new System.Drawing.Point(560, 110);
            this.btnUpdateScore.Name = "btnUpdateScore";
            this.btnUpdateScore.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateScore.TabIndex = 7;
            this.btnUpdateScore.Text = "Cập nhật";
            this.btnUpdateScore.UseVisualStyleBackColor = false;
            this.btnUpdateScore.Click += new System.EventHandler(this.btnUpdateScore_Click);
            // 
            // dgvUpdateScore
            // 
            this.dgvUpdateScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUpdateScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUpdateScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateScore.Location = new System.Drawing.Point(40, 160);
            this.dgvUpdateScore.Name = "dgvUpdateScore";
            this.dgvUpdateScore.Size = new System.Drawing.Size(620, 190);
            this.dgvUpdateScore.TabIndex = 22;
            this.dgvUpdateScore.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUpdateScore_CellMouseClick);
            // 
            // tbIdStd
            // 
            this.tbIdStd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbIdStd.Location = new System.Drawing.Point(110, 70);
            this.tbIdStd.Name = "tbIdStd";
            this.tbIdStd.Size = new System.Drawing.Size(121, 20);
            this.tbIdStd.TabIndex = 2;
            // 
            // UCUpdateScore
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tbIdStd);
            this.Controls.Add(this.dgvUpdateScore);
            this.Controls.Add(this.btnUpdateScore);
            this.Controls.Add(this.tbScore1);
            this.Controls.Add(this.tbScore2);
            this.Controls.Add(this.tbNameStudent);
            this.Controls.Add(this.tbNameSubject);
            this.Controls.Add(this.cbbIdClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "UCUpdateScore";
            this.Size = new System.Drawing.Size(700, 400);
            this.Load += new System.EventHandler(this.UCUpdateScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbIdClass;
        private System.Windows.Forms.TextBox tbNameSubject;
        private System.Windows.Forms.TextBox tbNameStudent;
        private System.Windows.Forms.TextBox tbScore2;
        private System.Windows.Forms.TextBox tbScore1;
        private System.Windows.Forms.Button btnUpdateScore;
        private System.Windows.Forms.DataGridView dgvUpdateScore;
        private System.Windows.Forms.TextBox tbIdStd;
    }
}
