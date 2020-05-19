namespace DoAnTuDienAV
{
    partial class frmBQT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBQT));
            this.pbBQT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBQT)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBQT
            // 
            this.pbBQT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBQT.Image = global::DoAnTuDienAV.Properties.Resources.bang_dong_tu_bat_quy_tac1;
            this.pbBQT.Location = new System.Drawing.Point(0, 0);
            this.pbBQT.Name = "pbBQT";
            this.pbBQT.Size = new System.Drawing.Size(699, 526);
            this.pbBQT.TabIndex = 0;
            this.pbBQT.TabStop = false;
            // 
            // frmBQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 526);
            this.Controls.Add(this.pbBQT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBQT";
            this.Text = "Bảng động từ bất quy tắc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBQT_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbBQT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBQT;
    }
}