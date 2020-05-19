using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTuDienAV
{
    public partial class frmThi : Form
    {
        public frmThi()
        {
            InitializeComponent();
        }

        private void btnHTD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiện tại đơn: \n1.Công thức với động từ thường : \nKhẳng định:S + V_S/ES + O \nPhủ định: S+ DO/DOES + NOT + V(inf) +O \nNghi vấn: DO/DOES + S + V(inf) + O ?  \n2.Công thức với động từ Tobe: \nKhẳng định: S+ AM/IS/ARE + O \nPhủ định: S + AM/IS/ARE + NOT + O  \nNghi vấn: AM/IS/ARE + S + O ?");
        }

        private void btnHTTD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiện tại tiếp diễn: \nKhẳng định: S +am/ is/ are + V_ing + O \nPhủ định: S + am/ is/ are+ not + V_ing + O \nNghi vấn:Am/is/are+S + V_ing+ O ?");
        }

        private void btnHTHT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiện tại hoàn thành: \nKhẳng định:S + have/ has + V3/ED+ O \nPhủ định:S + have/ has+ NOT + V3/ED+ O \nNghi vấn:Have/ has + S+ V3/ED+ O ?");
        }
        private void btnHTHTTD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiện tại hoàn thành tiếp diễn :\nKhẳng định: S + have/ has + been + V_ing + O \nPhủ định: S + haven’t/ hasn’t + been + V-ing \nNghi vấn:  Have/ Has + S + been + V-ing ?");
        }

        private void btnQKD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quá khứ đơn: \n1.Công thức đối với động từ thường: \nKhẳng định:S + V2/ED + O \nPhủ định: S + did + not+ V(inf) + O \nNghi vấn: Did + S + V(inf) + O ? \n2.Công thức với động từ Tobe: \nDạng bị động của thì quá khứ đơn: \nKhẳng định: S+ Were/Was + V_ed/V3 \nPhủ định: S + Were/Was + V_ed/V3 \nNghi vấn: Were/Was + S + V_ed/V3 ?");
        }

        private void btnQKTD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quá khứ tiếp diễn: \nKhẳng định: S + was/were + V_ing + O \nPhủ định: S + was/were+ not + V_ing + O \nNghi vấn: Was/were+S+ V_ing + O ?");
        }

        private void btnQKHT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quá khứ hoàn thành: \nKhẳng định: S + had + V3/ED + O \nPhủ định: S + had+ not + V3/ED + O \nNghi vấn: Had +S + V3/ED + O ?");
        }

        private void btnQKHTTD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quá khứ hoàn thành tiếp diễn: \nKhẳng định: S + had + been + V-ing + O \nPhủ định: S + had+ not + been + V-ing \nNghi vấn: Had + S + been + V-ing ?");
        }

        private void btnTLD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tương lai đơn: \nKhẳng định:S + shall/will + V(infinitive) + O \nPhủ định: S + shall/will + not + V(infinitive) + O \nNghi vấn: Shall/will+S + V(infinitive) + O ? ");
        }

        private void btnTLTD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tương lai tiếp diễn: \nKhẳng định:S + shall/will + V(infinitive) + O \nPhủ định: S + shall/will + not + V(infinitive) + O \nNghi vấn: Shall/will+S + V(infinitive) + O ? ");
        }

        private void btnTLHT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tương lai hoàn thành: \nKhẳng định:S + shall/will + have + V3/ED \nPhủ định: S + shall/will + not + have + V3/ED \nNghi vấn: Shall/Will+ S + have + V3/ED ? ");
        }

        private void btnTLHTTD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tương lai hoàn thành tiếp diễn: \nKhẳng định: S + shall/will + have been + V-ing + O \nPhủ định: S + shall/will not/ won’t + have + been + V-ing \nNghi vấn: Shall/Will + S+ have been + V-ing + O ?");
        }

        private void frmThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

      
    }
}
