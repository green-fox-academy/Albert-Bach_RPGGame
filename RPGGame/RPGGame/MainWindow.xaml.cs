using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace RPGGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hero hero;
        Map map;
        FoxDraw foxDraw;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            map = new Map();
            hero = new Hero();

            map.MapDrawer(foxDraw);
            hero.HeroDrawer(foxDraw);

        }


        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            map = new Map();
            map.MapDrawer(foxDraw);


            if (e.Key == Key.Left)
            {
                hero.WalkLeft(foxDraw);
            }

            if (e.Key == Key.Right)
            {
                hero.WalkRight(foxDraw);
            }

            if (e.Key == Key.Up)
            {
                hero.WalkUp(foxDraw);
            }

            if (e.Key == Key.Down)
            {
                hero.WalkDown(foxDraw);
            }
        }

    }
}