namespace DoAnTuDienAV
{
    partial class frmQuyTac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuyTac));
            this.btnED = new System.Windows.Forms.Button();
            this.btnSES = new System.Windows.Forms.Button();
            this.btnTrongAm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnED
            // 
            this.btnED.Location = new System.Drawing.Point(12, 93);
            this.btnED.Name = "btnED";
            this.btnED.Size = new System.Drawing.Size(264, 23);
            this.btnED.TabIndex = 0;
            this.btnED.Text = "Cách phát âm ED";
            this.btnED.UseVisualStyleBackColor = true;
            this.btnED.Click += new System.EventHandler(this.btnED_Click);
            // 
            // btnSES
            // 
            this.btnSES.Location = new System.Drawing.Point(12, 136);
            this.btnSES.Name = "btnSES";
            this.btnSES.Size = new System.Drawing.Size(264, 23);
            this.btnSES.TabIndex = 0;
            this.btnSES.Text = "Cách phát âm ES và S";
            this.btnSES.UseVisualStyleBackColor = true;
            this.btnSES.Click += new System.EventHandler(this.btnSES_Click);
            // 
            // btnTrongAm
            // 
            this.btnTrongAm.Location = new System.Drawing.Point(12, 176);
            this.btnTrongAm.Name = "btnTrongAm";
            this.btnTrongAm.Size = new System.Drawing.Size(264, 23);
            this.btnTrongAm.TabIndex = 0;
            this.btnTrongAm.Text = "Quy Tắc Trọng Âm";
            this.btnTrongAm.UseVisualStyleBackColor = true;
            this.btnTrongAm.Click += new System.EventHandler(this.btnTrongAm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quy Tắc Phát Âm";
            // 
            // frmQuyTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(288, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrongAm);
            this.Controls.Add(this.btnSES);
            this.Controls.Add(this.btnED);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuyTac";
            this.Text = "Quy Tắc Từ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuyTac_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnED;
        private System.Windows.Forms.Button btnSES;
        private System.Windows.Forms.Button btnTrongAm;
        private System.Windows.Forms.Label label1;
    }
}