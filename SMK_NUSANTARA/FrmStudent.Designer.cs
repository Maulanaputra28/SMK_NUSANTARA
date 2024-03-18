namespace SMK_NUSANTARA
{
    partial class FrmStudent
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
            this.lblStdntId = new System.Windows.Forms.Label();
            this.lblStdntName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGndr = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtBoxStdntID = new System.Windows.Forms.TextBox();
            this.txtBoxStdntName = new System.Windows.Forms.TextBox();
            this.rchTxtBoxAddrs = new System.Windows.Forms.RichTextBox();
            this.rdiobtnMale = new System.Windows.Forms.RadioButton();
            this.rdiobtnFemale = new System.Windows.Forms.RadioButton();
            this.dteTimePickerDoB = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Student";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(815, 172);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblStdntId
            // 
            this.lblStdntId.AutoSize = true;
            this.lblStdntId.Location = new System.Drawing.Point(268, 348);
            this.lblStdntId.Name = "lblStdntId";
            this.lblStdntId.Size = new System.Drawing.Size(68, 16);
            this.lblStdntId.TabIndex = 2;
            this.lblStdntId.Text = "Student ID";
            // 
            // lblStdntName
            // 
            this.lblStdntName.AutoSize = true;
            this.lblStdntName.Location = new System.Drawing.Point(268, 377);
            this.lblStdntName.Name = "lblStdntName";
            this.lblStdntName.Size = new System.Drawing.Size(92, 16);
            this.lblStdntName.TabIndex = 3;
            this.lblStdntName.Text = "Student Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(268, 408);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // lblGndr
            // 
            this.lblGndr.AutoSize = true;
            this.lblGndr.Location = new System.Drawing.Point(268, 508);
            this.lblGndr.Name = "lblGndr";
            this.lblGndr.Size = new System.Drawing.Size(52, 16);
            this.lblGndr.TabIndex = 5;
            this.lblGndr.Text = "Gender";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(268, 539);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(79, 16);
            this.lblDoB.TabIndex = 6;
            this.lblDoB.Text = "Date of Birth";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(268, 572);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(97, 16);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtBoxStdntID
            // 
            this.txtBoxStdntID.Location = new System.Drawing.Point(386, 345);
            this.txtBoxStdntID.Name = "txtBoxStdntID";
            this.txtBoxStdntID.Size = new System.Drawing.Size(248, 22);
            this.txtBoxStdntID.TabIndex = 8;
            this.txtBoxStdntID.TextChanged += new System.EventHandler(this.txtBoxStdntID_TextChanged);
            // 
            // txtBoxStdntName
            // 
            this.txtBoxStdntName.Location = new System.Drawing.Point(386, 371);
            this.txtBoxStdntName.Name = "txtBoxStdntName";
            this.txtBoxStdntName.Size = new System.Drawing.Size(248, 22);
            this.txtBoxStdntName.TabIndex = 9;
            this.txtBoxStdntName.TextChanged += new System.EventHandler(this.txtBoxStdntName_TextChanged);
            // 
            // rchTxtBoxAddrs
            // 
            this.rchTxtBoxAddrs.Location = new System.Drawing.Point(386, 399);
            this.rchTxtBoxAddrs.Name = "rchTxtBoxAddrs";
            this.rchTxtBoxAddrs.Size = new System.Drawing.Size(248, 74);
            this.rchTxtBoxAddrs.TabIndex = 10;
            this.rchTxtBoxAddrs.Text = "";
            this.rchTxtBoxAddrs.TextChanged += new System.EventHandler(this.rchTxtBoxAddrs_TextChanged);
            // 
            // rdiobtnMale
            // 
            this.rdiobtnMale.AutoSize = true;
            this.rdiobtnMale.Location = new System.Drawing.Point(405, 506);
            this.rdiobtnMale.Name = "rdiobtnMale";
            this.rdiobtnMale.Size = new System.Drawing.Size(58, 20);
            this.rdiobtnMale.TabIndex = 11;
            this.rdiobtnMale.TabStop = true;
            this.rdiobtnMale.Text = "Male";
            this.rdiobtnMale.UseVisualStyleBackColor = true;
            this.rdiobtnMale.CheckedChanged += new System.EventHandler(this.rdiobtnMale_CheckedChanged);
            // 
            // rdiobtnFemale
            // 
            this.rdiobtnFemale.AutoSize = true;
            this.rdiobtnFemale.Location = new System.Drawing.Point(514, 504);
            this.rdiobtnFemale.Name = "rdiobtnFemale";
            this.rdiobtnFemale.Size = new System.Drawing.Size(74, 20);
            this.rdiobtnFemale.TabIndex = 12;
            this.rdiobtnFemale.TabStop = true;
            this.rdiobtnFemale.Text = "Female";
            this.rdiobtnFemale.UseVisualStyleBackColor = true;
            this.rdiobtnFemale.CheckedChanged += new System.EventHandler(this.rdiobtnFemale_CheckedChanged);
            // 
            // dteTimePickerDoB
            // 
            this.dteTimePickerDoB.Location = new System.Drawing.Point(385, 534);
            this.dteTimePickerDoB.Name = "dteTimePickerDoB";
            this.dteTimePickerDoB.Size = new System.Drawing.Size(248, 22);
            this.dteTimePickerDoB.TabIndex = 13;
            this.dteTimePickerDoB.ValueChanged += new System.EventHandler(this.dteTimePickerDoB_ValueChanged);
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(386, 568);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(247, 22);
            this.txtBoxPhone.TabIndex = 14;
            this.txtBoxPhone.TextChanged += new System.EventHandler(this.txtBoxPhone_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(276, 627);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(105, 43);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(428, 627);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 43);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(586, 627);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 43);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(344, 694);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 43);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(513, 694);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 43);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 775);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.dteTimePickerDoB);
            this.Controls.Add(this.rdiobtnFemale);
            this.Controls.Add(this.rdiobtnMale);
            this.Controls.Add(this.rchTxtBoxAddrs);
            this.Controls.Add(this.txtBoxStdntName);
            this.Controls.Add(this.txtBoxStdntID);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.lblGndr);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblStdntName);
            this.Controls.Add(this.lblStdntId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblStdntId;
        private System.Windows.Forms.Label lblStdntName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGndr;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtBoxStdntID;
        private System.Windows.Forms.TextBox txtBoxStdntName;
        private System.Windows.Forms.RichTextBox rchTxtBoxAddrs;
        private System.Windows.Forms.RadioButton rdiobtnMale;
        private System.Windows.Forms.RadioButton rdiobtnFemale;
        private System.Windows.Forms.DateTimePicker dteTimePickerDoB;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}