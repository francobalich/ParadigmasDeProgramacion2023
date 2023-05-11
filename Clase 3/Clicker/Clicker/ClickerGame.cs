using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public class ClickerGame
    {
        private Objeto cubo = new Objeto();
        private int damage;

        public Objeto Cubo
        {
            get { return this.cubo; }
        }

        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }

        public ClickerGame()
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            Damage = genRandom.Next(500, 5000 + 1);
        }
        public void InitGame()
        {
            cubo = new Objeto();
        }

        public void MakeDamage()
        {
            if (cubo.ActualLife > 0)
            {
                cubo.ActualLife = cubo.ActualLife - Damage;
            }
            else
            {
                MessageBox.Show("¡Felicidades lograste picar el cubo!", "Lo lograste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
