
namespace ProjectQLSV_N12.Views.ucStudent
{
    partial class UCResultStudy
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
            this.tbIdStd = new System.Windows.Forms.TextBox();
            this.tbNameStd = new System.Windows.Forms.MaskedTextBox();
            this.tbNameClass = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvShowRs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên lớp";
            // 
            // tbIdStd
            // 
            this.tbIdStd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbIdStd.Location = new System.Drawing.Point(113, 30);
            this.tbIdStd.Name = "tbIdStd";
            this.tbIdStd.ReadOnly = true;
            this.tbIdStd.Size = new System.Drawing.Size(120, 20);
            this.tbIdStd.TabIndex = 1;
            // 
            // tbNameStd
            // 
            this.tbNameStd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbNameStd.Location = new System.Drawing.Point(331, 30);
            this.tbNameStd.Name = "tbNameStd";
            this.tbNameStd.ReadOnly = true;
            this.tbNameStd.Size = new System.Drawing.Size(120, 20);
            this.tbNameStd.TabIndex = 2;
            // 
            // tbNameClass
            // 
            this.tbNameClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbNameClass.Location = new System.Drawing.Point(540, 30);
            this.tbNameClass.Name = "tbNameClass";
            this.tbNameClass.ReadOnly = true;
            this.tbNameClass.Size = new System.Drawing.Size(120, 20);
            this.tbNameClass.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(36, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bảng điểm học tập";
            // 
            // dgvShowRs
            // 
            this.dgvShowRs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowRs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowRs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowRs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowRs.Location = new System.Drawing.Point(40, 127);
            this.dgvShowRs.Name = "dgvShowRs";
            this.dgvShowRs.Size = new System.Drawing.Size(620, 241);
            this.dgvShowRs.TabIndex = 5;
            // 
            // UCResultStudy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dgvShowRs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNameClass);
            this.Controls.Add(this.tbNameStd);
            this.Controls.Add(this.tbIdStd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "UCResultStudy";
            this.Size = new System.Drawing.Size(700, 400);
            this.Load += new System.EventHandler(this.UCResultStudy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdStd;
        private System.Windows.Forms.MaskedTextBox tbNameStd;
        private System.Windows.Forms.MaskedTextBox tbNameClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvShowRs;
    }
}
