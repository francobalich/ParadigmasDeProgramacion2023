using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    public class Objeto
    {
		private int life;
		private int actualLife;

		public int Life
		{
			get { return life; }
			set { life = value; }
		}

		public int ActualLife
		{
			get { return actualLife; }
			set { actualLife = value; }
		}

        public Objeto()
        {
            Random genRandom = new Random((int)DateTime.Now.Ticks);
            Life = genRandom.Next(3000, 30000 + 1);
            ActualLife = Life;
        }
    }
}
