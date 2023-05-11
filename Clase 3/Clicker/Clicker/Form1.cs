using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;

namespace Clicker
{
    public partial class Form1 : Form
    {
        private ClickerGame game = new ClickerGame();

        public Form1()
        {
            InitializeComponent();
        }

        private void initGame()
        {
            game.InitGame();
            lblHealth.Text = "Vida: " + game.Cubo.ActualLife.ToString();
            lblDamage.Text = "Daño: " + game.Damage.ToString();
            pbxEnemy.Show();
            pbxEnemy.Size = new Size(250, 250);
        }
        private void makeDamage()
        {
            game.MakeDamage();

            if (game.Cubo.ActualLife > 0)
            {
                lblHealth.Text = "Vida: " + game.Cubo.ActualLife.ToString();
                float scale = (float)game.Cubo.ActualLife / (float)game.Cubo.Life;
                SizeF size = new SizeF(scale, scale);
                pbxEnemy.Scale(size);
            }
            else
            {
                lblHealth.Text = "Vida: 0";
                pbxEnemy.Hide();
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
