using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaNumerosMelhorado
{
    public partial class FrmSoma : Form
    {
        public FrmSoma()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i, num, mult, result, soma = 0;
            int number1, number2;
            bool entrada1 = Int32.TryParse(txtNum.Text, out number1);
            bool entrada2 = Int32.TryParse(txtNum.Text, out number2);
            if (entrada1 || entrada2)
            {
                num = Convert.ToInt32(txtNum.Text);
                mult = Convert.ToInt32(txtMult.Text);
                for (i = 1; i <= mult; i++)
                {
                    result = num * i;
                    soma += result;
                }
                txtSoma.Text = soma.ToString();
            }
            else
            {
                MessageBox.Show("Digite um número!");
            }
                       
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSoma.Clear();
            txtMult.Clear();
            txtNum.Clear();
            txtNum.Focus();
        }
    }
}
