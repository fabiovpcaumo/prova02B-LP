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
    public partial class FormOption1 : Form
    {

        TextBoxHelper tbHelper = new TextBoxHelper();
      
        public FormOption1()
        {
            InitializeComponent();
        }

        private double convertToCelsius(double tempFahrenheit)
        {
            return (tempFahrenheit - 32) * 5/9 ;
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            double tempFahrenheit;

            if (tbHelper.validateInput(tbFahrenheit.Text))
            {
                tempFahrenheit = Convert.ToDouble(tbFahrenheit.Text);
                double convertedResult = convertToCelsius(tempFahrenheit);
                tbCelsius.Text = convertedResult.ToString();
            }
            else
            {
                tbCelsius.Text = "Valores numéricos apenas.";
            }
        }
    }
}
