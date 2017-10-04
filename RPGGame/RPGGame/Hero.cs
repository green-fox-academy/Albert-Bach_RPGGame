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
        static string HeroDown = "./Assets/hero-down.png";
        static string HeroLeft = "./Assets/hero-left.png";
        static string HeroRight = "./Assets/hero-right.png";
        static string HeroUp = "./Assets/hero-up.png";
        Map map = new Map();
        int pointX = 50;
        int pointY = 50;
        int moveMent = 50;

        public void HeroDrawer(FoxDraw foxDraw)
        {
            foxDraw.AddImage(HeroDown, pointX, pointY);
        }

        public void WalkLeft(FoxDraw foxDraw)
        {
            if (pointX > 50 && map.Field[(pointY - 50) / 50][(pointX - 50) / 50 - 1])
            {
                pointX -= moveMent;
            }
            foxDraw.AddImage(HeroLeft, pointX, pointY);
        }

        public void WalkRight(FoxDraw foxDraw)
        {
            if (pointX < 500 && map.Field[(pointY - 50) / 50][(pointX - 50) / 50 + 1])
            {
                pointX += moveMent;
            }
            foxDraw.AddImage(HeroRight, pointX, pointY);
        }

        public void WalkUp(FoxDraw foxDraw)
        {
            if (pointY > 50 && map.Field[(pointY - 50) / 50 - 1][(pointX - 50) / 50])
            {
                pointY -= moveMent;
            }
            foxDraw.AddImage(HeroUp, pointX, pointY);
        }

        public void WalkDown(FoxDraw foxDraw)
        {
            if (pointY < 500 && map.Field[(pointY - 50) / 50 + 1][(pointX - 50) / 50])
            {
                pointY += moveMent;
            }
            foxDraw.AddImage(HeroDown, pointX, pointY);
        }

    }
}