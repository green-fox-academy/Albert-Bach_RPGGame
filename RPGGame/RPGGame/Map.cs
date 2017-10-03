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
        private string floorS = "./Assets/floor.png";
        private string wallS = "./Assets/wall.png";
        private int gameField = 50;
        int x = 0;
        int y = 0;

        private static List<bool[]> RockWall = new List<bool[]>
        {
           new bool[]{true,true,true,false,true,false,true,true,true,true},
           new bool[]{true,true,true,false,true,false,true,false,false,true},
           new bool[]{true,false,false,false,true,false,true,false,false,true},
           new bool[]{true,true,true,true,true,false,true,true,true,true},
           new bool[]{false,false,false,false,true,false,false,false,false,true},
           new bool[]{true,false,true,false,true,true,true,true,false,true},
           new bool[]{true,false,true,false,true,false,false,true,false,true},
           new bool[]{true,true,true,true,true,false,false,true,false,true},
           new bool[]{true,false,false,false,true,true,true,true,false,true},
           new bool[]{true,true,true,false,true,false,false,true,false,true}
        };


        public void MapDrawer(FoxDraw foxDraw)
        {
            for (int i = 0; i < RockWall.Count; i++)
            {
                x = 0;
                y += gameField;
                for (int j = 0; j < RockWall.Count; j++)
                {
                    x += gameField;
                    if (RockWall[i][j] == true)
                    {
                        foxDraw.AddImage(floorS, x, y);
                    }
                    else
                    {
                        foxDraw.AddImage(wallS, x, y);
                    }
                }
            }
        }
    }
}
