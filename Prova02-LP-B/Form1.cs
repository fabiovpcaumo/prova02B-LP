using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova02_LP_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOption1_Click(object sender, EventArgs e)
        {
            FormOption1 formOption1 = new FormOption1();
            formOption1.Show();
            this.Hide();
        }

        private void BtnOption2_Click(object sender, EventArgs e)
        {
            FormOption2 formOption2 = new FormOption2();
            formOption2.Show();
            this.Hide();
        }

        private void BtnOption3_Click(object sender, EventArgs e)
        {
            FormOption3 formOption3 = new FormOption3();
            formOption3.Show();
            this.Hide();
        }

        private void BtnOption4_Click(object sender, EventArgs e)
        {
            FormOption4 formOption4 = new FormOption4();
            formOption4.Show();
            this.Hide();
        }

        private void BtnOption5_Click(object sender, EventArgs e)
        {

        }
    }
}
