namespace SMK_NUSANTARA
{
    partial class a
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsrt = new System.Windows.Forms.Button();
            this.lblTchrId = new System.Windows.Forms.Label();
            this.lblTchrNme = new System.Windows.Forms.Label();
            this.lblAddrss = new System.Windows.Forms.Label();
            this.lblGndr = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblNohp = new System.Windows.Forms.Label();
            this.txtTchrId = new System.Windows.Forms.TextBox();
            this.txtTchrNme = new System.Windows.Forms.TextBox();
            this.txtNohp = new System.Windows.Forms.TextBox();
            this.rchTbAddrs = new System.Windows.Forms.RichTextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.btnUpdt = new System.Windows.Forms.Button();
            this.btnDlt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Teacher";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(125, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(899, 253);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnInsrt
            // 
            this.btnInsrt.Location = new System.Drawing.Point(295, 742);
            this.btnInsrt.Name = "btnInsrt";
            this.btnInsrt.Size = new System.Drawing.Size(119, 34);
            this.btnInsrt.TabIndex = 2;
            this.btnInsrt.Text = "Insert";
            this.btnInsrt.UseVisualStyleBackColor = true;
            this.btnInsrt.Click += new System.EventHandler(this.btnInsrt_Click);
            // 
            // lblTchrId
            // 
            this.lblTchrId.AutoSize = true;
            this.lblTchrId.Location = new System.Drawing.Point(221, 437);
            this.lblTchrId.Name = "lblTchrId";
            this.lblTchrId.Size = new System.Drawing.Size(74, 16);
            this.lblTchrId.TabIndex = 3;
            this.lblTchrId.Text = "Teacher ID";
            // 
            // lblTchrNme
            // 
            this.lblTchrNme.AutoSize = true;
            this.lblTchrNme.Location = new System.Drawing.Point(221, 466);
            this.lblTchrNme.Name = "lblTchrNme";
            this.lblTchrNme.Size = new System.Drawing.Size(98, 16);
            this.lblTchrNme.TabIndex = 4;
            this.lblTchrNme.Text = "Teacher Name";
            // 
            // lblAddrss
            // 
            this.lblAddrss.AutoSize = true;
            this.lblAddrss.Location = new System.Drawing.Point(221, 501);
            this.lblAddrss.Name = "lblAddrss";
            this.lblAddrss.Size = new System.Drawing.Size(58, 16);
            this.lblAddrss.TabIndex = 5;
            this.lblAddrss.Text = "Address";
            // 
            // lblGndr
            // 
            this.lblGndr.AutoSize = true;
            this.lblGndr.Location = new System.Drawing.Point(221, 610);
            this.lblGndr.Name = "lblGndr";
            this.lblGndr.Size = new System.Drawing.Size(52, 16);
            this.lblGndr.TabIndex = 6;
            this.lblGndr.Text = "Gender";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(221, 640);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(73, 16);
            this.lblDob.TabIndex = 7;
            this.lblDob.Text = "DateofBirth";
            // 
            // lblNohp
            // 
            this.lblNohp.AutoSize = true;
            this.lblNohp.Location = new System.Drawing.Point(221, 682);
            this.lblNohp.Name = "lblNohp";
            this.lblNohp.Size = new System.Drawing.Size(43, 16);
            this.lblNohp.TabIndex = 8;
            this.lblNohp.Text = "NoHp";
            // 
            // txtTchrId
            // 
            this.txtTchrId.Location = new System.Drawing.Point(339, 432);
            this.txtTchrId.Name = "txtTchrId";
            this.txtTchrId.Size = new System.Drawing.Size(496, 22);
            this.txtTchrId.TabIndex = 9;
            this.txtTchrId.TextChanged += new System.EventHandler(this.txtTchrId_TextChanged);
            // 
            // txtTchrNme
            // 
            this.txtTchrNme.Location = new System.Drawing.Point(339, 460);
            this.txtTchrNme.Name = "txtTchrNme";
            this.txtTchrNme.Size = new System.Drawing.Size(496, 22);
            this.txtTchrNme.TabIndex = 10;
            this.txtTchrNme.TextChanged += new System.EventHandler(this.txtTchrNme_TextChanged);
            // 
            // txtNohp
            // 
            this.txtNohp.Location = new System.Drawing.Point(338, 676);
            this.txtNohp.Name = "txtNohp";
            this.txtNohp.Size = new System.Drawing.Size(496, 22);
            this.txtNohp.TabIndex = 11;
            this.txtNohp.TextChanged += new System.EventHandler(this.txtNohp_TextChanged);
            // 
            // rchTbAddrs
            // 
            this.rchTbAddrs.Location = new System.Drawing.Point(338, 488);
            this.rchTbAddrs.Name = "rchTbAddrs";
            this.rchTbAddrs.Size = new System.Drawing.Size(496, 101);
            this.rchTbAddrs.TabIndex = 12;
            this.rchTbAddrs.Text = "";
            this.rchTbAddrs.TextChanged += new System.EventHandler(this.rchTbAddrs_TextChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(371, 606);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 13;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(570, 608);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 20);
            this.rbFemale.TabIndex = 14;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // dtpDoB
            // 
            this.dtpDoB.Location = new System.Drawing.Point(338, 644);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(495, 22);
            this.dtpDoB.TabIndex = 15;
            this.dtpDoB.ValueChanged += new System.EventHandler(this.dtpDoB_ValueChanged);
            // 
            // btnUpdt
            // 
            this.btnUpdt.Location = new System.Drawing.Point(481, 742);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(119, 34);
            this.btnUpdt.TabIndex = 16;
            this.btnUpdt.Text = "Update";
            this.btnUpdt.UseVisualStyleBackColor = true;
            this.btnUpdt.Click += new System.EventHandler(this.btnUpdt_Click);
            // 
            // btnDlt
            // 
            this.btnDlt.Location = new System.Drawing.Point(650, 742);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(119, 34);
            this.btnDlt.TabIndex = 17;
            this.btnDlt.Text = "Delete";
            this.btnDlt.UseVisualStyleBackColor = true;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(382, 799);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 34);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(570, 799);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 34);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 860);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.btnUpdt);
            this.Controls.Add(this.dtpDoB);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rchTbAddrs);
            this.Controls.Add(this.txtNohp);
            this.Controls.Add(this.txtTchrNme);
            this.Controls.Add(this.txtTchrId);
            this.Controls.Add(this.lblNohp);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblGndr);
            this.Controls.Add(this.lblAddrss);
            this.Controls.Add(this.lblTchrNme);
            this.Controls.Add(this.lblTchrId);
            this.Controls.Add(this.btnInsrt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "a";
            this.Text = "ManageTeacherForm";
            this.Load += new System.EventHandler(this.a_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsrt;
        private System.Windows.Forms.Label lblTchrId;
        private System.Windows.Forms.Label lblTchrNme;
        private System.Windows.Forms.Label lblAddrss;
        private System.Windows.Forms.Label lblGndr;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblNohp;
        private System.Windows.Forms.TextBox txtTchrId;
        private System.Windows.Forms.TextBox txtTchrNme;
        private System.Windows.Forms.TextBox txtNohp;
        private System.Windows.Forms.RichTextBox rchTbAddrs;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.Button btnUpdt;
        private System.Windows.Forms.Button btnDlt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}