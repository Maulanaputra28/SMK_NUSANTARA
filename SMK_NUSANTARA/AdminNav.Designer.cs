namespace SMK_NUSANTARA
{
    partial class AdminNav
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.btnManageStudnet = new System.Windows.Forms.Button();
            this.btnManageTeacher = new System.Windows.Forms.Button();
            this.btnManageClass = new System.Windows.Forms.Button();
            this.btnManageSchedule = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // labelAdminName
            // 
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.Location = new System.Drawing.Point(114, 71);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(93, 16);
            this.labelAdminName.TabIndex = 1;
            this.labelAdminName.Text = "[Admin Name]";
            // 
            // btnManageStudnet
            // 
            this.btnManageStudnet.Location = new System.Drawing.Point(151, 135);
            this.btnManageStudnet.Name = "btnManageStudnet";
            this.btnManageStudnet.Size = new System.Drawing.Size(184, 28);
            this.btnManageStudnet.TabIndex = 2;
            this.btnManageStudnet.Text = "Manage Student";
            this.btnManageStudnet.UseVisualStyleBackColor = true;
            this.btnManageStudnet.Click += new System.EventHandler(this.btnManageStudnet_Click);
            // 
            // btnManageTeacher
            // 
            this.btnManageTeacher.Location = new System.Drawing.Point(153, 191);
            this.btnManageTeacher.Name = "btnManageTeacher";
            this.btnManageTeacher.Size = new System.Drawing.Size(181, 30);
            this.btnManageTeacher.TabIndex = 3;
            this.btnManageTeacher.Text = "Manage Teacher";
            this.btnManageTeacher.UseVisualStyleBackColor = true;
            this.btnManageTeacher.Click += new System.EventHandler(this.btnManageTeacher_Click);
            // 
            // btnManageClass
            // 
            this.btnManageClass.Location = new System.Drawing.Point(154, 248);
            this.btnManageClass.Name = "btnManageClass";
            this.btnManageClass.Size = new System.Drawing.Size(179, 32);
            this.btnManageClass.TabIndex = 4;
            this.btnManageClass.Text = "Manage Class";
            this.btnManageClass.UseVisualStyleBackColor = true;
            this.btnManageClass.Click += new System.EventHandler(this.btnManageClass_Click);
            // 
            // btnManageSchedule
            // 
            this.btnManageSchedule.Location = new System.Drawing.Point(158, 308);
            this.btnManageSchedule.Name = "btnManageSchedule";
            this.btnManageSchedule.Size = new System.Drawing.Size(174, 35);
            this.btnManageSchedule.TabIndex = 5;
            this.btnManageSchedule.Text = "Manage Schedule";
            this.btnManageSchedule.UseVisualStyleBackColor = true;
            this.btnManageSchedule.Click += new System.EventHandler(this.btnManageSchedule_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(160, 369);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(171, 34);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 474);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageSchedule);
            this.Controls.Add(this.btnManageClass);
            this.Controls.Add(this.btnManageTeacher);
            this.Controls.Add(this.btnManageStudnet);
            this.Controls.Add(this.labelAdminName);
            this.Controls.Add(this.label1);
            this.Name = "AdminNav";
            this.Text = "AdminNavigation";
            this.Load += new System.EventHandler(this.AdminNav_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.Button btnManageStudnet;
        private System.Windows.Forms.Button btnManageTeacher;
        private System.Windows.Forms.Button btnManageClass;
        private System.Windows.Forms.Button btnManageSchedule;
        private System.Windows.Forms.Button btnLogout;
    }
}