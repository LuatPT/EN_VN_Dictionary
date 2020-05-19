namespace DoAnTuDienAV
{
    partial class frmPXNhanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPXNhanh));
            this.lbQuestion = new System.Windows.Forms.ListBox();
            this.txbCheck = new System.Windows.Forms.TextBox();
            this.btnNghe = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRS = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txbQues = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.FormattingEnabled = true;
            this.lbQuestion.Location = new System.Drawing.Point(21, 60);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(79, 277);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Click += new System.EventHandler(this.lbQuestion_Click);
            // 
            // txbCheck
            // 
            this.txbCheck.Location = new System.Drawing.Point(119, 262);
            this.txbCheck.Name = "txbCheck";
            this.txbCheck.Size = new System.Drawing.Size(228, 20);
            this.txbCheck.TabIndex = 1;
            this.txbCheck.Text = "Nhập_câu_trả_lời_vào_đây...";
            // 
            // btnNghe
            // 
            this.btnNghe.Location = new System.Drawing.Point(119, 306);
            this.btnNghe.Name = "btnNghe";
            this.btnNghe.Size = new System.Drawing.Size(79, 31);
            this.btnNghe.TabIndex = 2;
            this.btnNghe.Text = "Nghe";
            this.btnNghe.UseVisualStyleBackColor = true;
            this.btnNghe.Click += new System.EventHandler(this.btnNghe_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(268, 306);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(79, 31);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(197, 214);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 29);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(282, 214);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRS
            // 
            this.btnRS.Location = new System.Drawing.Point(119, 72);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(228, 29);
            this.btnRS.TabIndex = 2;
            this.btnRS.Text = "Cài đặt";
            this.btnRS.UseVisualStyleBackColor = true;
            this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(112, 214);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 29);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txbQues
            // 
            this.txbQues.Location = new System.Drawing.Point(119, 133);
            this.txbQues.Name = "txbQues";
            this.txbQues.Size = new System.Drawing.Size(228, 20);
            this.txbQues.TabIndex = 1;
            this.txbQues.Text = "Nhập_câu_hỏi...";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(119, 107);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(228, 20);
            this.txbID.TabIndex = 1;
            this.txbID.Text = "Nhập_id_câu_hỏi...";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(119, 159);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(228, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Đóng phần cài đặt";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(83, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phản Xạ Nhanh 3s";
            // 
            // frmPXNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(359, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnRS);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnNghe);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.txbQues);
            this.Controls.Add(this.txbCheck);
            this.Controls.Add(this.lbQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPXNhanh";
            this.Text = "frmPXNhanh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPXNhanh_FormClosing);
            this.Load += new System.EventHandler(this.frmPXNhanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbQuestion;
        private System.Windows.Forms.TextBox txbCheck;
        private System.Windows.Forms.Button btnNghe;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnRS;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbQues;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
    }
}