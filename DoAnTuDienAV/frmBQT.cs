﻿using System;
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
    public partial class frmBQT : Form
    {
        public frmBQT()
        {
            InitializeComponent();
        }

        private void frmBQT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
