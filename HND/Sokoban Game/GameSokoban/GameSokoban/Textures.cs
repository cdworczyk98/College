using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace GameSokoban
{
    class Textures
    {
        //-----Game graphics-----// These are all the image sources that will be applied to the image objects
        public BitmapImage Tile_Floor { get; set; }
        public BitmapImage Tile_Wall { get; set; }
        public BitmapImage Tile_Button { get; set; }
        public BitmapImage Tile_Crate { get; set; }
        public BitmapImage Sprite_Player { get; set; }

        public Textures()
        {
            //takes the images from the resources and links them with the correct variable 
            Tile_Floor = new BitmapImage(new Uri("pack://application:,,,/Resources/Tiles/Tile_Floor.png", UriKind.Absolute));
            Tile_Wall = new BitmapImage(new Uri("pack://application:,,,/Resources/Tiles/Tile_Wall.bmp", UriKind.Absolute));
            Tile_Button = new BitmapImage(new Uri("pack://application:,,,/Resources/Tiles/Tile_Button.bmp", UriKind.Absolute));
            Tile_Crate = new BitmapImage(new Uri("pack://application:,,,/Resources/Tiles/Tile_Crate.bmp", UriKind.Absolute));
            Sprite_Player = new BitmapImage(new Uri("pack://application:,,,/Resources/Sprites/Sprite_Player.png", UriKind.Absolute));
        }
    }
}
