
namespace ProjectQLSV_N12.Views.ucAdmin
{
    partial class UCManageTeaching
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
            this.dgvManageTeaching = new System.Windows.Forms.DataGridView();
            this.btnDivision = new System.Windows.Forms.Button();
            this.cbbIdClass = new System.Windows.Forms.ComboBox();
            this.cbbIdTch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTeaching)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageTeaching
            // 
            this.dgvManageTeaching.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManageTeaching.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageTeaching.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvManageTeaching.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageTeaching.Location = new System.Drawing.Point(44, 89);
            this.dgvManageTeaching.Name = "dgvManageTeaching";
            this.dgvManageTeaching.ReadOnly = true;
            this.dgvManageTeaching.Size = new System.Drawing.Size(616, 276);
            this.dgvManageTeaching.TabIndex = 12;
            // 
            // btnDivision
            // 
            this.btnDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.White;
            this.btnDivision.Location = new System.Drawing.Point(560, 35);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(100, 30);
            this.btnDivision.TabIndex = 11;
            this.btnDivision.Text = "Phân công";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // cbbIdClass
            // 
            this.cbbIdClass.FormattingEnabled = true;
            this.cbbIdClass.Location = new System.Drawing.Point(383, 40);
            this.cbbIdClass.Name = "cbbIdClass";
            this.cbbIdClass.Size = new System.Drawing.Size(145, 21);
            this.cbbIdClass.TabIndex = 10;
            // 
            // cbbIdTch
            // 
            this.cbbIdTch.FormattingEnabled = true;
            this.cbbIdTch.Location = new System.Drawing.Point(142, 40);
            this.cbbIdTch.Name = "cbbIdTch";
            this.cbbIdTch.Size = new System.Drawing.Size(145, 21);
            this.cbbIdTch.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã lớp học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã giáo viên";
            // 
            // UCManageTeaching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvManageTeaching);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.cbbIdClass);
            this.Controls.Add(this.cbbIdTch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "UCManageTeaching";
            this.Size = new System.Drawing.Size(700, 400);
            this.Load += new System.EventHandler(this.UCManageTeaching_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTeaching)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManageTeaching;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.ComboBox cbbIdClass;
        private System.Windows.Forms.ComboBox cbbIdTch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
