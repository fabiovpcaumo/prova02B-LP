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
    public partial class FormExercicio02 : Form
    {
        public FormExercicio02()
        {
            InitializeComponent();
        }

        TextBoxHelper tbHelper = new TextBoxHelper();
        int[] numbers = new int[] { };
        string positiveNumbers = "";
        int negativeCount = 0;

        private bool addToArray(int number)
        {
            if (numbers.Length < 5)
            {
                
                Array.Resize(ref numbers, numbers.Length + 1); //Redimensiona o Array para caber mais um número


                numbers[numbers.Length - 1] = number; //Insere um número na última posição do array


                // Atualiza as estatisticas
                if (number >= 0)
                {
                    positiveNumbers += number + " ";
                }
                else
                {
                    negativeCount += 1;
                }

                //Altera os textboxes na UI
                tbArrayValues.Text += number + " ";
                tbCountNegativeNumbers.Text = negativeCount.ToString();
                tbPositiveNumbers.Text = positiveNumbers;

                return true;
            }
            return false;
        }

        private void clearArray()
        {
            numbers = new int[] { };
            positiveNumbers = "";
            negativeCount = 0;
            tbArrayValues.Text = "";
            tbCountNegativeNumbers.Text = "0";
            tbPositiveNumbers.Text = "";
        }

        private void BtnAddToArray_Click(object sender, EventArgs e)
        {
            if (tbHelper.validateInput(tbNewNumber.Text))
            {
                if (!addToArray(Convert.ToInt32(tbNewNumber.Text)))
                {
                    tbNewNumber.Text = "Apenas 5 números por vez no vetor";
                }
            }
            else
            {
                tbNewNumber.Text = "Apenas números inteiros.";
            }
            
        }

        private void BtnClearArray_Click(object sender, EventArgs e)
        {
            clearArray();
        }
    }
}
