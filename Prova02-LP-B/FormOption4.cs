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
    public partial class FormOption4 : Form
    {
        TextBoxHelper tbHelper = new TextBoxHelper();
        public FormOption4()
        {
            InitializeComponent();
        }

        private void BtnInvert_Click(object sender, EventArgs e)
        {
            int valorA, valorB;
           
            if(tbHelper.validateInput(tbValorA.Text) && tbHelper.validateInput(tbValorB.Text)){
                valorA = Convert.ToInt32(tbValorA.Text);
                valorB = Convert.ToInt32(tbValorB.Text);

                int aux = valorA;
                valorA = valorB;
                valorB = aux;

                tbValorA.Text = valorA.ToString();
                tbValorB.Text = valorB.ToString();
             }
        }
    }
}
