
namespace ProjectQLSV_N12.Views
{
    partial class fTeacherSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTeacherSystem));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.searchStudent = new System.Windows.Forms.Button();
            this.studyScore = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbTitleTop = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.searchStudent);
            this.pnlMenu.Controls.Add(this.studyScore);
            this.pnlMenu.Controls.Add(this.ptbLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 500);
            this.pnlMenu.TabIndex = 3;
            // 
            // searchStudent
            // 
            this.searchStudent.FlatAppearance.BorderSize = 0;
            this.searchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStudent.ForeColor = System.Drawing.Color.White;
            this.searchStudent.Location = new System.Drawing.Point(0, 180);
            this.searchStudent.Name = "searchStudent";
            this.searchStudent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.searchStudent.Size = new System.Drawing.Size(200, 50);
            this.searchStudent.TabIndex = 1;
            this.searchStudent.Text = "Tìm kiếm sinh viên";
            this.searchStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchStudent.UseVisualStyleBackColor = true;
            this.searchStudent.Click += new System.EventHandler(this.searchStudent_Click);
            // 
            // studyScore
            // 
            this.studyScore.FlatAppearance.BorderSize = 0;
            this.studyScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyScore.ForeColor = System.Drawing.Color.White;
            this.studyScore.Location = new System.Drawing.Point(0, 130);
            this.studyScore.Name = "studyScore";
            this.studyScore.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.studyScore.Size = new System.Drawing.Size(200, 50);
            this.studyScore.TabIndex = 1;
            this.studyScore.Text = "Điểm học tập";
            this.studyScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studyScore.UseVisualStyleBackColor = true;
            this.studyScore.Click += new System.EventHandler(this.studyScore_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(40, 10);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(120, 120);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Controls.Add(this.lbTitleTop);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(700, 100);
            this.pnlTop.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnLogout.Location = new System.Drawing.Point(520, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 50);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbTitleTop
            // 
            this.lbTitleTop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTitleTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.lbTitleTop.Location = new System.Drawing.Point(40, 25);
            this.lbTitleTop.Name = "lbTitleTop";
            this.lbTitleTop.Size = new System.Drawing.Size(300, 50);
            this.lbTitleTop.TabIndex = 0;
            this.lbTitleTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(200, 100);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(700, 400);
            this.pnlContainer.TabIndex = 5;
            // 
            // fTeacherSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.Name = "fTeacherSystem";
            this.Text = "fTeacherSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fTeacherSystem_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button searchStudent;
        private System.Windows.Forms.Button studyScore;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lbTitleTop;
        private System.Windows.Forms.Panel pnlContainer;
    }
}