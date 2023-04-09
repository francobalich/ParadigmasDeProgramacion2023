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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            int numRandom = genRandom.Next(0, 1 + 1);

            if (numRandom == 1){
                pbxCara.Show();
                pbxCruz.Hide();
            }
            else{
                pbxCara.Hide();
                pbxCruz.Show();
            }
        }
    }
}
