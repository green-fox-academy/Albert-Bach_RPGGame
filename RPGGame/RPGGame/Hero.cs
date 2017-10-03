using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Hero : Characters
    {
        private string myHero = "./Assets/hero-down.png";
        int x = 0;
        int y = 0;

        public void HeroDrawer(FoxDraw foxDraw)
        {
            foxDraw.AddImage(myHero, x+50, y+50);

        }
    }
}
