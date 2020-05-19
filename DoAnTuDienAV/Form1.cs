using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
//Khai bao SD thu vien SQL Helper
using Microsoft.ApplicationBlocks.Data;
namespace DoAnTuDienAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgvFind.Hide();
            txbShortVN.Hide();
            txbVN.Hide();
        }
        private void btnQL_Click(object sender, EventArgs e)
        {
            //An nut dieu khien se hien phan dang nhap
            frmQuanLyTu frm = new frmQuanLyTu();
            frm.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult TB;
            TB = MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (TB == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnPhatAm_Click(object sender, EventArgs e)
        {
            SpVoice phatam = new SpVoice();
            phatam.Speak(txbEnglish.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void txbEnglish_TextChanged(object sender, EventArgs e)
        {

        }
        private void setvalue(int index)
        {
            try
            {
                //Tao 1 datagridview row
                DataGridViewRow row = dtgvFind.Rows[index];
                //Truyen nguoc tu Datagridview ->TextBox
                txbEnglish.Text = row.Cells[0].Value.ToString();
                txbVN.Text = row.Cells[1].Value.ToString();
                txbShortVN.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvFind_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txbShortVN.Show();
            txbVN.Show();
            setvalue(e.RowIndex);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvFind.Show();
                //gia tri tim dc se luu trong bang tam thoi -> textbox
                string eng = txbEnglish.Text.Trim();
                DataTable ds = SqlHelper.ExecuteDataset(SQLstring.strCon, "AV_NangCao", eng).Tables[0];
                //kiem tra ton tai
                if (ds.Rows.Count > 0)
                {

                    dtgvFind.DataSource = SqlHelper.ExecuteDataset(SQLstring.strCon, "AV_NangCao", eng).Tables[0];
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnVietAnh_Click(object sender, EventArgs e)
        {
            frmVietAnh frm = new frmVietAnh();
            frm.Show();
            this.Hide();
        }

        private void btn360_Click(object sender, EventArgs e)
        {
            frmBQT frm = new frmBQT();
            frm.Show();
            this.Hide();
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            frmThi frm1 = new frmThi();
            frm1.Show();
            this.Hide();
        }

        private void btnTu_Click(object sender, EventArgs e)
        {
            frmQuyTac frm2 = new frmQuyTac();
            frm2.Show();
            this.Hide();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            frmPXNhanh frm3 = new frmPXNhanh();
            frm3.Show();
            this.Hide();
        }

    }
}
