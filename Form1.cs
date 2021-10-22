using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroPrimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(txtIngreso.Text);




            if (checkPrimo(numero) == false)
            {
                MessageBox.Show("Numero ingresado no es primo");
            }
            else
            {
                MessageBox.Show("Numero ingresado es primo");
            }


        }


        private Boolean checkPrimo(int numero)
        {
            Boolean isPrimo = true;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    isPrimo = false;
                }
            }

            return isPrimo;
        }

    }
}
