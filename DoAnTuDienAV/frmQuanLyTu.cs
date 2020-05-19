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
    public partial class frmQuanLyTu : Form
    {
        public frmQuanLyTu()
        {
            InitializeComponent();
        }
        private void frmQuanLyTu_Load(object sender, EventArgs e)
        {
            btnXoaTrang.PerformClick();
        }
     
        private void setvalue(int index)
        {
            try
            {
                //Tao 1 datagridview row
                DataGridViewRow row = gridItemData.Rows[index];
                //Truyen nguoc tu Datagridview ->TextBox
                txbID.Text = row.Cells[2].Value.ToString();
                txbEnglish.Text =row.Cells[0].Value.ToString();
                txbShortVn.Text =row.Cells[3].Value.ToString();
                txbVN.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void gridItemData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            setvalue(e.RowIndex);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //khai bao 4 bien truyen vao
                string id = txbID.Text.Trim();
                string eng = txbEnglish.Text.Trim();
                string shortVn = txbShortVn.Text.Trim();
                string vn = txbVN.Text.Trim();
                //Truyen du lieu len SP
                SqlHelper.ExecuteNonQuery(SQLstring.strCon, "AV_Them", eng, vn, id, shortVn);
                MessageBox.Show("Thêm thành công!");
                btnFind.PerformClick();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txbID.Clear();
            txbEnglish.Clear();
            txbShortVn.Clear();
            txbVN.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txbID.Text.Trim();
                SqlHelper.ExecuteNonQuery(SQLstring.strCon, "AV_Xoa", id);
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txbID.Text.Trim();
                string eng = txbEnglish.Text.Trim();
                string shortVn = txbShortVn.Text.Trim();
                string vn = txbVN.Text.Trim();
                SqlHelper.ExecuteNonQuery(SQLstring.strCon, "AV_Sua", eng, vn, id, shortVn);
                MessageBox.Show("Sửa thành công!");
                btnFind.PerformClick();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmQuanLyTu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            SpVoice phatam = new SpVoice();
            phatam.Speak(txbEnglish.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
             try
            {
               
                //gia tri tim dc se luu trong bang tam thoi -> textbox
                string eng = txbEnglish.Text.Trim();
                DataTable ds = SqlHelper.ExecuteDataset(SQLstring.strCon, "AV_TraTu", eng).Tables[0];
                //kiem tra ton tai
                if (ds.Rows.Count > 0)
                {

                    gridItemData.DataSource = SqlHelper.ExecuteDataset(SQLstring.strCon, "AV_TraTu", eng).Tables[0];
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        }

        }
