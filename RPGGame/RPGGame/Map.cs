using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Map
    {
        public static int gameField = 50;
        public static string floorS = "./Assets/floor.png";
        public static string wallS = "./Assets/wall.png";

        public void Tiles(FoxDraw foxDraw)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    foxDraw.AddImage(floorS, x, y);
                    x += gameField;
                }
                y += gameField;
                x = 0;

            }
        }
    }
}
