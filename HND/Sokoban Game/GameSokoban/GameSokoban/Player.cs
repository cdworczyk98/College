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
using Microsoft.Win32;

namespace GameSokoban
{
    class Player
    {
        //keeps track of the X and Y coordiates of player
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string playerName { get; set; } //leeps track of the player name
        

        public Player(int x, int y, string name, GamePage gp) //constructor takes the X and Y of player where to creat and also passes the GamePage refrence so this class can call its functions
        {
            PosX = x;
            PosY = y;
            playerName = name;

            gp.CreateTile(PosX, PosY, gp.Textures.Sprite_Player, "tile_Player");
        }
    }
}
