using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using SpeechLib;

namespace DoAnTuDienAV
{
    public partial class frmPXNhanh : Form
    {
        public frmPXNhanh()
        {
            InitializeComponent();
            txbQues.Hide();
            txbID.Hide();
            btnThem.Hide();
            btnSua.Hide();
            btnXoa.Hide();
            btnThoat.Hide();
        }

        private void frmPXNhanh_Load(object sender, EventArgs e)
        {
            LoadListBoxData();
            loaddata();
        }
        private void btnNghe_Click(object sender, EventArgs e)
        {
            SpVoice phatam = new SpVoice();
            phatam.Speak(txbQues.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            txbID.Show();
            txbQues.Show();
            btnThoat.Show();
            btnThem.Show();
            btnSua.Show();
            btnXoa.Show();
        }
        private void LoadListBoxData()
        {
            try
            {
                DataTable ds = SqlHelper.ExecuteDataset(SQLstring.strCon, "Test_Select").Tables[0];
                lbQuestion.DataSource = ds;
                lbQuestion.DisplayMember = "id";
                lbQuestion.ValueMember = "ques";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void lbQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = lbQuestion.Text;
                DataTable ds = SqlHelper.ExecuteDataset(SQLstring.strCon, "Test_TraTu", temp).Tables[0];
                txbID.Text = lbQuestion.Text;
                if (ds.Rows.Count > 0)
                {
                    txbID.Text = ds.Rows[0]["id"].ToString();
                    txbQues.Text = ds.Rows[0]["ques"].ToString();
                }
                else
                {
                    MessageBox.Show("Câu bạn tìm ko có trong CSDL?!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if(txbCheck.Text == txbQues.Text)
                {
                    MessageBox.Show("Chúc mừng bạn đã nghe chính xác");
                }
                else
                {
                    MessageBox.Show("Bạn đã nghe sai.Vui lòng thử lại");
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void loaddata()
        {
            lbQuestion.DataSource = SqlHelper.ExecuteDataset(SQLstring.strCon, "Test_Select").Tables[0];
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txbID.Text.Trim();
                string ques = txbQues.Text.Trim();
                SqlHelper.ExecuteNonQuery(SQLstring.strCon, "Test_Sua", id,ques);
                MessageBox.Show("Sửa thành công!");
                loaddata();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                 //khai bao 2 bien truyen vao
                string id = txbID.Text.Trim();
                string ques  = txbQues.Text.Trim();
                //Truyen du lieu len SP
                SqlHelper.ExecuteNonQuery(SQLstring.strCon, "Test_Them", id,ques);
                MessageBox.Show("Thêm thành công!");
                loaddata();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                string id = txbID.Text.Trim();
                SqlHelper.ExecuteNonQuery(SQLstring.strCon, "Test_Xoa", id);
                MessageBox.Show("Xóa thành công!");
                loaddata();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmPXNhanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult TB;
            TB = MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (TB == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            txbID.Hide();
            txbQues.Hide();
            btnThem.Hide();
            btnSua.Hide();
            btnXoa.Hide();
            btnThoat.Hide();
        }

    }
}
