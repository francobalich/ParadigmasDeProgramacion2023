using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_la_moneda
{
    public partial class Form1 : Form
    {
        private Coin moneda;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            moneda = new Coin();
            moneda.Cruz = pbxCruz;
            moneda.Cara = pbxCara;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            GeneradorRandom genRandom = new GeneradorRandom();
            int a = genRandom.generarNumero(0,1);
            moneda.MostrarCara(genRandom.NumeroRandom);
        }
         
    }
}
