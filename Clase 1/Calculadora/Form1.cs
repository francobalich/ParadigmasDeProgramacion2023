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
        public Form1()
        {
            InitializeComponent();
        }

        private int sumar(int primerNum, int segundoNum)
        {
            return primerNum + segundoNum;
        }
        private int restar(string primerNum, string segundoNum)
        {
            int primerEntrada = Convert.ToInt32(primerNum);
            int segundaEntrada = Convert.ToInt32(segundoNum);
            return primerEntrada - segundaEntrada;
        }
        private string multiplicar(TextBox primerTxt, TextBox segundoTxt)
        {
            int primerEntrada = Convert.ToInt32(primerTxt.Text);
            int segundaEntrada = Convert.ToInt32(segundoTxt.Text);
            string resultado = (primerEntrada * segundaEntrada).ToString();
            return resultado;
        }
        private string dividir(TextBox primerTxt, TextBox segundoTxt)
        {
            try
            {
                decimal primerEntrada = Convert.ToDecimal(primerTxt.Text);
                decimal segundaEntrada = Convert.ToDecimal(segundoTxt.Text);
                string resultado = (primerEntrada / segundaEntrada).ToString();
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "No se pudo realizar la operaciòn";
            }
        }
        private string calcular(TextBox primerTxt, TextBox segundoTxt, string operacion)
        {
            try
            {
                decimal primerEntrada = Convert.ToDecimal(primerTxt.Text);
                decimal segundaEntrada = Convert.ToDecimal(segundoTxt.Text);
                string resultado = "";
                switch (operacion)
                {
                    case "+":
                        resultado=(primerEntrada + segundaEntrada).ToString();
                        break;
                    case "-":
                        resultado = (primerEntrada - segundaEntrada).ToString();
                        break;
                    case "/":
                        resultado = (primerEntrada / segundaEntrada).ToString();
                        break;
                    case "*":
                        resultado = (primerEntrada * segundaEntrada).ToString();
                        break;
                    case "**":
                        resultado = Math.Pow((double)primerEntrada, (double)segundaEntrada).ToString();
                        break;
                    default:
                        break;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "No se pudo realizar la operaciòn";
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                int primerEntrada = Convert.ToInt32(txtPrimerEntrada.Text);
                int segundaEntrada = Convert.ToInt32(txtSegundaEntrada.Text);
                int resultado = sumar(primerEntrada, segundaEntrada);

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
                int resultado = restar(txtPrimerEntrada.Text,txtSegundaEntrada.Text);
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
                lblResultado.Text = multiplicar(txtPrimerEntrada, txtSegundaEntrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text=dividir(txtPrimerEntrada, txtSegundaEntrada);
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            lblResultado.Text = calcular(txtPrimerEntrada, txtSegundaEntrada,"**");
        }
    }
}
