namespace SMK_NUSANTARA.Dto
{
    partial class MngClassForm
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
            this.lblClssnme = new System.Windows.Forms.Label();
            this.lblStdntLst = new System.Windows.Forms.Label();
            this.lblPrtcpt = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnPrtcptStndt = new System.Windows.Forms.Button();
            this.btnStdntLst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClssnme
            // 
            this.lblClssnme.AutoSize = true;
            this.lblClssnme.Location = new System.Drawing.Point(58, 88);
            this.lblClssnme.Name = "lblClssnme";
            this.lblClssnme.Size = new System.Drawing.Size(81, 16);
            this.lblClssnme.TabIndex = 0;
            this.lblClssnme.Text = "Class Name";
            // 
            // lblStdntLst
            // 
            this.lblStdntLst.AutoSize = true;
            this.lblStdntLst.Location = new System.Drawing.Point(58, 165);
            this.lblStdntLst.Name = "lblStdntLst";
            this.lblStdntLst.Size = new System.Drawing.Size(75, 16);
            this.lblStdntLst.TabIndex = 1;
            this.lblStdntLst.Text = "Student List";
            // 
            // lblPrtcpt
            // 
            this.lblPrtcpt.AutoSize = true;
            this.lblPrtcpt.Location = new System.Drawing.Point(559, 165);
            this.lblPrtcpt.Name = "lblPrtcpt";
            this.lblPrtcpt.Size = new System.Drawing.Size(119, 16);
            this.lblPrtcpt.TabIndex = 2;
            this.lblPrtcpt.Text = "Participate Student";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 398);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(562, 209);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(344, 398);
            this.dataGridView2.TabIndex = 5;
            // 
            // btnPrtcptStndt
            // 
            this.btnPrtcptStndt.Location = new System.Drawing.Point(447, 343);
            this.btnPrtcptStndt.Name = "btnPrtcptStndt";
            this.btnPrtcptStndt.Size = new System.Drawing.Size(74, 39);
            this.btnPrtcptStndt.TabIndex = 6;
            this.btnPrtcptStndt.Text = ">>";
            this.btnPrtcptStndt.UseVisualStyleBackColor = true;
            this.btnPrtcptStndt.Click += new System.EventHandler(this.btnPrtcptStndt_Click_1);
            // 
            // btnStdntLst
            // 
            this.btnStdntLst.Location = new System.Drawing.Point(449, 388);
            this.btnStdntLst.Name = "btnStdntLst";
            this.btnStdntLst.Size = new System.Drawing.Size(72, 35);
            this.btnStdntLst.TabIndex = 7;
            this.btnStdntLst.Text = "<<";
            this.btnStdntLst.UseVisualStyleBackColor = true;
            this.btnStdntLst.Click += new System.EventHandler(this.btnStdntLst_Click);
            // 
            // MngClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 687);
            this.Controls.Add(this.btnStdntLst);
            this.Controls.Add(this.btnPrtcptStndt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPrtcpt);
            this.Controls.Add(this.lblStdntLst);
            this.Controls.Add(this.lblClssnme);
            this.Name = "MngClassForm";
            this.Text = "MngClassForm";
            this.Load += new System.EventHandler(this.MngClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClssnme;
        private System.Windows.Forms.Label lblStdntLst;
        private System.Windows.Forms.Label lblPrtcpt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnPrtcptStndt;
        private System.Windows.Forms.Button btnStdntLst;
    }
}