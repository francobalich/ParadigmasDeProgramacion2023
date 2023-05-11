using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public class Calculadora
    {
        public Calculadora() { }

        public int Sumar(int primerNum, int segundoNum)
        {
            return primerNum + segundoNum;
        }
        public int Restar(string primerNum, string segundoNum)
        {
            int primerEntrada = Convert.ToInt32(primerNum);
            int segundaEntrada = Convert.ToInt32(segundoNum);
            return primerEntrada - segundaEntrada;
        }
        public string Multiplicar(TextBox primerTxt, TextBox segundoTxt)
        {
            int primerEntrada = Convert.ToInt32(primerTxt.Text);
            int segundaEntrada = Convert.ToInt32(segundoTxt.Text);
            string resultado = (primerEntrada * segundaEntrada).ToString();
            return resultado;
        }
        public string Dividir(TextBox primerTxt, TextBox segundoTxt)
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
        public string Calcular(TextBox primerTxt, TextBox segundoTxt, string operacion)
        {
            try
            {
                decimal primerEntrada = Convert.ToDecimal(primerTxt.Text);
                decimal segundaEntrada = Convert.ToDecimal(segundoTxt.Text);
                string resultado = "";
                switch (operacion)
                {
                    case "+":
                        resultado = (primerEntrada + segundaEntrada).ToString();
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
    }
}
