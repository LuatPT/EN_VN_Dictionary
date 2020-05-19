namespace DoAnTuDienAV
{
    partial class frmVietAnh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVietAnh));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvFind = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.txbVN = new System.Windows.Forms.TextBox();
            this.txbEnglish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFind)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvFind);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.txbVN);
            this.groupBox2.Controls.Add(this.txbEnglish);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 363);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm Từ";
            // 
            // dtgvFind
            // 
            this.dtgvFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFind.Location = new System.Drawing.Point(276, 132);
            this.dtgvFind.Name = "dtgvFind";
            this.dtgvFind.Size = new System.Drawing.Size(129, 211);
            this.dtgvFind.TabIndex = 2;
            this.dtgvFind.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFind_RowEnter);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(340, 41);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(41, 31);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txbVN
            // 
            this.txbVN.Location = new System.Drawing.Point(19, 132);
            this.txbVN.Multiline = true;
            this.txbVN.Name = "txbVN";
            this.txbVN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbVN.Size = new System.Drawing.Size(224, 211);
            this.txbVN.TabIndex = 3;
            // 
            // txbEnglish
            // 
            this.txbEnglish.Location = new System.Drawing.Point(123, 47);
            this.txbEnglish.Name = "txbEnglish";
            this.txbEnglish.Size = new System.Drawing.Size(193, 20);
            this.txbEnglish.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chi Tiết :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ Cần Tra :";
            // 
            // frmVietAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(424, 363);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVietAnh";
            this.Text = "Từ Điển Việt Anh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainApp_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbEnglish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbVN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dtgvFind;
    }
}