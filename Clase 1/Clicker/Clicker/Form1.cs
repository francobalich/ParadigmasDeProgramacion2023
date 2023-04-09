using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int life = 0;
        public int actualLife = 0;
        public int damage = 0;


        private void initGame()
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            life = genRandom.Next(3000, 30000 + 1);
            actualLife = life;
            damage = genRandom.Next(500, 5000 + 1);
            lblHealth.Text = "Vida: " + actualLife.ToString();
            lblDamage.Text = "Daño: " + damage.ToString();
            pbxEnemy.Show();
            pbxEnemy.Size = new Size(250,250);
        }

        private void makeDamage()
        {
            if (actualLife > 0)
            {
                actualLife = actualLife - damage;
                if (actualLife > 0)
                {
                    lblHealth.Text = "Vida: " + actualLife.ToString();
                    float scale = (float)actualLife / (float)life;
                    SizeF size = new SizeF(scale, scale);
                    pbxEnemy.Scale(size);
                }
                else
                {
                    lblHealth.Text = "Vida: 0";
                    pbxEnemy.Hide();
                }
            }
            else
            {
                MessageBox.Show("¡Felicidades lograste picar el cubo!", "Lo lograste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initGame();   
        }

        private void pbxEnemy_Click(object sender, EventArgs e)
        {
            makeDamage();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            makeDamage();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            initGame();
        }
    }
}
