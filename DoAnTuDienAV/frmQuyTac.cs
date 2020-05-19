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
    public partial class frmQuyTac : Form
    {
        public frmQuyTac()
        {
            InitializeComponent();
        }

        private void btnED_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Đuôi /ed/ được phát âm là /id/: Khi động từ có phát âm kết thúc là /t/ hay /d/. \n\n2. Đuôi /ed/ được phát âm là /t/: Khi động từ có phát âm kết thúc là /s/, /f/, /p/, /ʃ/, /tʃ/, /k/ và những động từ có từ phát âm cuối là /s/. \n\n3. Đuôi /ed/ được phát âm là /d/ với những trường hợp còn lại.");
        }

        private void btnSES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Phát âm là /s/ \n Khi từ có tận cùng bằng các phụ âm vô thanh: /ð/, /p/, /k/, /f/, /t/.\nChúng ta cứ tạm dịch là “Thời phong kiến phương tây” cho dễ nhớ nhen! \n\n2. Phát âm là /iz/ \n Khi từ có tận cùng là các âm: /s/, /z/, /ʃ/, /tʃ/, /ʒ/, /dʒ/. \nThường có tận cùng là các chữ cái sh, ce, s, z, ge, ch, x \n\n3. Phát âm là /z/ \nKhi các từ có tận cùng là nguyên âm và các phụ âm hữu thanh còn lại.");
        }

        private void btnTrongAm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Phần lớn động từ và giới từ có 2 âm tiết có trọng âm rơi vào âm tiết thứ hai. \n\n2.Hầu hết danh từ và tính từ có 2 âm tiết đều có trọng âm rơi vào âm tiết thứ nhất.\n\n3.Với những từ có 3 âm tiết trở lên, trọng âm thường rơi vào âm tiết thứ 3 tính từ cuối lên.\n\n4.Các từ tận cùng bằng các đuôi – ic, – ish, – ical, – sion, – tion, – ance, – ence, – idle, – ious, – iar, – ience, – id, – eous, – ian, – ity thì thì trọng âm nhấn vào âm tiết ngay trước nó.\n\n5.Các từ có hậu tố: – ee, – eer, – ese, – ique, – esque , – ain thì trọng âm rơi vào chính âm tiết đó.\n\n6. Các từ có hậu tố: – ment, – ship, – ness, – er/ or, – hood, – ing, – en, – ful, – able, – ous, – less thì trọng âm chính của từ không thay đổi.\n\n7. Các từ tận cùng – graphy, – ate, – gy, – cy, – ity, – phy, – al thì trọng âm rơi vào âm tiết thứ 3 từ dưới lên.\n\n8.Danh từ ghép: Trọng âm thường rơi vào âm tiết thứ 1.\n\n9.Tính từ ghép (thường có dấu gạch ngang ở giữa): Trọng âm rơi vào từ thứ hai.");
        }

        private void frmQuyTac_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
