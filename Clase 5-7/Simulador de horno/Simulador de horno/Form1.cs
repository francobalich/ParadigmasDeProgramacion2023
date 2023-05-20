using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_horno
{
    public partial class Form1 : Form
    {
        private Horno horno = new Horno();
        private string elemento="";
        private double temperatura=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void trbTemp_Scroll(object sender, EventArgs e)
        {
            try
            {
                lblTemp.Text = $"{trbTemp.Value.ToString()}°C";

                if(elemento!=""&&temperatura!=0)
                {
                    horno.Temperatura = trbTemp.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void validacion()
        {
            elemento = txtElemento.Text;
            bool success = double.TryParse(txtTemperatura.Text, out temperatura);
            if (!success)
            {
                MessageBox.Show("La temperatura tiene que ser un numero");
            }
            horno.ElementoACocinar = elemento;
            horno.TemperaturaDeCoccion = temperatura;
        }

        private void txtElemento_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }

        private void txtTemperatura_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }
        private void ComidaCocinada(object sender, CoccionEventArgs e)
        {
            lblMensaje.Text = $"¡La {e.Elemento} se cocino a {e.Temperatura}°C!" ;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            horno.Coccion += ComidaCocinada;
        }
    }
}
