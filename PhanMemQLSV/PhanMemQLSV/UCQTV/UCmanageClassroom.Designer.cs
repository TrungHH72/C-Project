
namespace PhanMemQLSV.UCQTV
{
    partial class UCmanageClassroom
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
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.cbbIdClassroom = new System.Windows.Forms.ComboBox();
            this.cbbIdClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvManageClassroom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageClassroom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnCreateRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateRoom.FlatAppearance.BorderSize = 0;
            this.btnCreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoom.ForeColor = System.Drawing.Color.White;
            this.btnCreateRoom.Location = new System.Drawing.Point(560, 45);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(100, 30);
            this.btnCreateRoom.TabIndex = 14;
            this.btnCreateRoom.Text = "Lập phòng";
            this.btnCreateRoom.UseVisualStyleBackColor = false;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // cbbIdClassroom
            // 
            this.cbbIdClassroom.FormattingEnabled = true;
            this.cbbIdClassroom.Location = new System.Drawing.Point(404, 50);
            this.cbbIdClassroom.Name = "cbbIdClassroom";
            this.cbbIdClassroom.Size = new System.Drawing.Size(120, 21);
            this.cbbIdClassroom.TabIndex = 12;
            // 
            // cbbIdClass
            // 
            this.cbbIdClass.FormattingEnabled = true;
            this.cbbIdClass.Location = new System.Drawing.Point(152, 50);
            this.cbbIdClass.Name = "cbbIdClass";
            this.cbbIdClass.Size = new System.Drawing.Size(120, 21);
            this.cbbIdClass.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã lớp học";
            // 
            // dgvManageClassroom
            // 
            this.dgvManageClassroom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManageClassroom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageClassroom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvManageClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageClassroom.Location = new System.Drawing.Point(44, 111);
            this.dgvManageClassroom.Name = "dgvManageClassroom";
            this.dgvManageClassroom.ReadOnly = true;
            this.dgvManageClassroom.Size = new System.Drawing.Size(616, 264);
            this.dgvManageClassroom.TabIndex = 15;
            // 
            // UCmanageClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvManageClassroom);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.cbbIdClassroom);
            this.Controls.Add(this.cbbIdClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "UCmanageClassroom";
            this.Size = new System.Drawing.Size(700, 400);
            this.Load += new System.EventHandler(this.UCmanageClassroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageClassroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.ComboBox cbbIdClassroom;
        private System.Windows.Forms.ComboBox cbbIdClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvManageClassroom;
    }
}
