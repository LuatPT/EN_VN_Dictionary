using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using SpeechLib;
namespace DoAnTuDienAV
{
    public partial class frmVietAnh : Form
    {

        public frmVietAnh()
        {
            InitializeComponent();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvFind.Show();
                //gia tri tim dc se luu trong bang tam thoi -> textbox
                string eng = txbEnglish.Text;
                DataTable ds = SqlHelper.ExecuteDataset(SQLstring.strCon, "VA_NangCao_Pro", eng).Tables[0];
                //kiem tra ton tai
                if (ds.Rows.Count > 0)
                {

                    dtgvFind.DataSource = SqlHelper.ExecuteDataset(SQLstring.strCon, "VA_NangCao_Pro", eng).Tables[0];
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmMainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dtgvFind_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            setvalue(e.RowIndex);
        }

        }

    }
