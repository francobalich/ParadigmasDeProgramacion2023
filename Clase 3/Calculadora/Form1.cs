using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private Calculadora calculadora = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                int primerEntrada = Convert.ToInt32(txtPrimerEntrada.Text);
                int segundaEntrada = Convert.ToInt32(txtSegundaEntrada.Text);
                int resultado = calculadora.Sumar(primerEntrada, segundaEntrada);

                lblResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = calculadora.Restar(txtPrimerEntrada.Text,txtSegundaEntrada.Text);
                lblResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = calculadora.Multiplicar(txtPrimerEntrada, txtSegundaEntrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text= calculadora.Dividir(txtPrimerEntrada, txtSegundaEntrada);
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            lblResultado.Text = calculadora.Calcular(txtPrimerEntrada, txtSegundaEntrada,"**");
        }

        
    }
}
