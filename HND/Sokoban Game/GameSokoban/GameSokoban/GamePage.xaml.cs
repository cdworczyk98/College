using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.IO;

namespace GameSokoban
{
    public partial class GamePage : Window
    {
        //-----Integers-----//
        public int CurrentLevel { get; set; } //keep track of loaded in level in integer form
        public int StepsTaken { get; set; } //keep track of steps taken by player
        public int NumberOfButtons { get; set; } //keeps track of number of exits. this number gets compared later on to see if level is completed

        public Image[,] Grid { get; set; } //array which the excel file numbers will be loaded into to allow the program to read the level

        internal Textures Textures { get; set; } //used to keep all the game textures
        public OpenFileDialog Ofd { get; set; }//used to prompt the user with select file window
        internal OpenFile Of { get; set; } //used to read in level text files
        Player Player; //player class with the X and Y coordinates

        public bool LevelLoaded { get; set; } //keeps track if the level is loaded 

        public GamePage()
        {
            InitializeComponent();

            CurrentLevel = 0;
            StepsTaken = 0;
            NumberOfButtons = 0;
            Textures = new Textures();
            Grid = new Image[15, 15];
            Ofd = new OpenFileDialog();
            Of = new OpenFile();
            LevelLoaded = false;
        }

        private void UpdateInfo()
        {
            Lable_Steps.Content = StepsTaken; //update the steps taken lable
            Label_Level.Content = CurrentLevel; //update the current level lable

            int buttonsPressed = 0; //local variable which will keep track of all the buttons pressed in the current loop run

            for (int i = 0; i < 15; i++) //nested loop
            {
                for (int j = 0; j < 15; j++)
                {
                    if (Grid[i, j].Source == Textures.Tile_Crate && Of.Level[i, j] == 2) //compare the dynamic image array with the static integer array to see if box is on a coordinate thta matches a button coodrinate
                    {
                        buttonsPressed++;
                        Console.WriteLine(buttonsPressed  + " " + NumberOfButtons);
                    }

                    if (i == 14 && j == 14) //if we are on the last loop run
                    {
                        if (buttonsPressed == NumberOfButtons) //check if the buttonsPressed match the amount of buttons in current level
                        {
                            NextLevel(); //load the next elvel
                        }
                    }
                }
            }
        }

        //listens for key presses
        private void Canvas_GameScene_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key) //switch case will check what key was pressed and send the correct string to the Move() function
            {
                case Key.Left: MovePlayer("left"); break;
                case Key.Right: MovePlayer("right"); break;
                case Key.Up: MovePlayer("up"); break;
                case Key.Down: MovePlayer("down"); break;
                default: break;
            }
        }

        //responsible for moving the player
        private void MovePlayer(string direction) 
        {
            int x = 0, y = 0; //these are temp variables that are used to check the blocks the player wants to move to
            switch (direction) //switch case which sets up the temp varible to be used in logic
            {
                case "left": x = 0; y = -1; break;
                case "right": x = 0; y = 1; break;
                case "up": x = -1; y = 0; break;
                case "down": x = 1; y = 0; break;
                default: break;
            }

            if (Grid[Player.PosX + x, Player.PosY + y].Source != Textures.Tile_Wall && Grid[Player.PosX + x, Player.PosY + y].Source != Textures.Tile_Crate) //if the tile at location 1+ from player is not a wall or a crate then...
            {
                StepsTaken++;

                if (Of.Level[Player.PosX, Player.PosY] == 2) //if the player is standing on a button then run this code to replace the correct tile under player
                {
                    Canvas_GameScene.Children.Remove(Grid[Player.PosX, Player.PosY]); //removes player sprite at current grid position
                    CreateTile(Player.PosX, Player.PosY, Textures.Tile_Button, "tile_Button"); //creates the button under the player
                    Player.PosX += x; //updates to the desired x and y position on the grid
                    Player.PosY += y; // <-----

                    CreateTile(Player.PosX, Player.PosY, Textures.Sprite_Player, "tile_Player"); //places the player tile back
                }
                else //if the player is just on a normal floor tile run this
                {
                    Canvas_GameScene.Children.Remove(Grid[Player.PosX, Player.PosY]); //removes player sprite at current grid position
                    CreateTile(Player.PosX, Player.PosY, Textures.Tile_Floor, "tile_Floor"); //replace it witha  floor tile
                    Player.PosX += x; //updates to the desired x and y position on the grid
                    Player.PosY += y; // <-----

                    CreateTile(Player.PosX, Player.PosY, Textures.Sprite_Player, "tile_Player");//places the player tile back
                }

                UpdateInfo(); //update at the end to check for al buttons
            }
            else if (Grid[Player.PosX + x, Player.PosY + y].Source == Textures.Tile_Crate && Grid[Player.PosX + x + x, Player.PosY + y + y].Source != Textures.Tile_Wall && Grid[Player.PosX + x + x, Player.PosY + y + y].Source != Textures.Tile_Crate) //if the player is trying to push a crate AND the crate is nnot being psuhed into a wall or another crate then...
            {
                StepsTaken++;
                MoveCrate(x, y); //call a seperate function to move the crate with x and y coordinate
                UpdateInfo();
            }
        }

        private void MoveCrate(int x, int y)
        {
            int crateX = Player.PosX + x, crateY = Player.PosY + y; //creat a temp varaible whihc holds the coordinate of crate

            if (Of.Level[crateX, crateY] == 2) //if the crate being moved is on a button then replace the tile a button tile
            {
                Canvas_GameScene.Children.Remove(Grid[crateX, crateY]); //remove crate
                CreateTile(crateX, crateY, Textures.Tile_Button, "tile_Button"); //replace tile with a button tile
                crateX += x; //update the coordinates of the crate
                crateY += y; // <-----------
                CreateTile(crateX, crateY, Textures.Tile_Crate, "tile_Crate"); //place crate on the tile it was pushed on

                if (Of.Level[Player.PosX, Player.PosY] == 2) //if the player is ALSO on a button the repalce the tile with a butotn tile
                {
                    Canvas_GameScene.Children.Remove(Grid[Player.PosX, Player.PosY]); //removes player sprite at current grid position
                    CreateTile(Player.PosX, Player.PosY, Textures.Tile_Button, "tile_Button");
                    Player.PosX += x; //updates to the desired x and y position on the grid
                    Player.PosY += y; // <-----
                    CreateTile(Player.PosX, Player.PosY, Textures.Sprite_Player, "tile_Player");
                }
                else //else repalce it with just a floor tile
                {
                    Canvas_GameScene.Children.Remove(Grid[Player.PosX, Player.PosY]); //removes player sprite at current grid position
                    Player.PosX += x; //updates to the desired x and y position on the grid
                    Player.PosY += y; // <-----
                    CreateTile(Player.PosX, Player.PosY, Textures.Sprite_Player, "tile_Player");
                }

            }
            else if (Of.Level[Player.PosX, Player.PosY] == 2 && Of.Level[crateX, crateY] != 2) //if the player is on a button BUT the crate isn't then repalce the tile with a button only under the player
            {
                Canvas_GameScene.Children.Remove(Grid[crateX, crateY]); //removes crate image
                CreateTile(crateX, crateY, Textures.Tile_Floor, "tile_Floor");
                crateX += x;
                crateY += y;

                Canvas_GameScene.Children.Remove(Grid[Player.PosX, Player.PosY]); //removes player sprite at current grid position
                CreateTile(Player.PosX, Player.PosY, Textures.Tile_Button, "tile_Button");
                Player.PosX += x; //updates to the desired x and y position on the grid
                Player.PosY += y; // <-----

                CreateTile(crateX, crateY, Textures.Tile_Crate, "tile_Crate");
                CreateTile(Player.PosX, Player.PosY, Textures.Sprite_Player, "tile_Player");
            }
            else //else if the box is just being pushed on normal floor tiles
            {
                Canvas_GameScene.Children.Remove(Grid[crateX, crateY]); //removes crate image
                CreateTile(crateX, crateY, Textures.Tile_Floor, "tile_Floor");
                crateX += x;
                crateY += y;

                Canvas_GameScene.Children.Remove(Grid[Player.PosX, Player.PosY]); //removes player sprite at current grid position
                CreateTile(Player.PosX, Player.PosY, Textures.Tile_Floor, "tile_Floor");
                Player.PosX += x; //updates to the desired x and y position on the grid
                Player.PosY += y; // <-----

                CreateTile(crateX, crateY, Textures.Tile_Crate, "tile_Crate");
                CreateTile(Player.PosX, Player.PosY, Textures.Sprite_Player, "tile_Player");
            }
        }

        private void LoadGridBox()
        {
            //nested loops which allows the levels to be generated on a 2D grid architecture
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    //each if statement is a different tile to be spawned in
                    //0 = Floor      1 = Wall     2 = Button    98 = Crate     99 = Player
                    if (Of.Level[x, y] == 0) CreateTile(x, y, Textures.Tile_Floor, "tile_Floor");
                    else if (Of.Level[x, y] == 1) CreateTile(x, y, Textures.Tile_Wall, "tile_Wall");
                    else if (Of.Level[x, y] == 2) 
                    {
                        CreateTile(x, y, Textures.Tile_Button, "tile_Button");
                        NumberOfButtons++;//if the tile being created is a button then increase the number of buttons in level
                    }
                    else if (Of.Level[x, y] == 98) CreateTile(x, y, Textures.Tile_Crate, "tile_Crate");
                    else if (Of.Level[x, y] == 99) Player = new Player(x, y, "tile_Player", this);
                }
            }
        }

        public void CreateTile(int x, int y, BitmapImage image, string name)
        {
            Grid[x,y] = new Image //creates instance of the image
            {
                Name = name,
                Source = image,
                Width = 32,
                Height = 32
            };

            //sets the x and y coordinates of ther image and adds it to the canvas children to display
            Canvas.SetLeft(Grid[x, y], y * 32);
            Canvas.SetTop(Grid[x, y], x * 32);
            Canvas_GameScene.Children.Add(Grid[x, y]);
        }

        private void LoadLevel(string path)
        {
            if(LevelLoaded) ClearLevel(); //if a level is already loaded then clear it

            if (Of.LoadFile(path)) //call the LoadFile function to load the level from the excel file
            {
                    LoadGridBox();//load the images onto the canvas
                    LevelLoaded = true; //chnage LevelLoaded to true
                    CurrentLevel = Int16.Parse(path.Substring(path.Length - 5, 1)); //takes the path and extracts the level number
            }
        }

        private void ClearLevel()
        {
            NumberOfButtons = 0; //resets amount of buttons in game

            foreach (Image image in Grid) //goes through all the images in Grid array aand removes the from the Canvas_GameScene
            {
                Canvas_GameScene.Children.Remove(image);
            }
        }

        private void NextLevel()
        {
            if (CurrentLevel == 3)
            {
                MessageBox.Show("You win!"); //if we are on the last level display winnning message
                Close(); //closes game
            }
            else
            {
                MessageBox.Show("You completed this level with: "+StepsTaken+" steps."); //displays mesage with how many steps it took to comeplete level
                StepsTaken = 0; //resets steps taken
                CurrentLevel++; //updates current level to next level
                LoadLevel(Directory.GetCurrentDirectory() + "\\Resources\\Levels\\Floor_" + CurrentLevel + ".txt"); //loads next level
            }

        } 

        private void Button_LoadLevel_Click(object sender, RoutedEventArgs e)
        {
            if (Ofd.ShowDialog() == true) //prompt user with a select file window where they can select a file
            {
                LoadLevel(Ofd.FileName); //call LoadLevel with the filepath to user selected level
            }
        }

        private void Button_Restart_Click(object sender, RoutedEventArgs e)
        {
            //only if a level is already loaded in will this restart the level
            if (LevelLoaded) LoadLevel(Directory.GetCurrentDirectory() + "\\Resources\\Levels\\Floor_" + CurrentLevel + ".txt");
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow(); //create the MainWindow object
            mw.Show(); //display the mainWindow
            Close(); //close the gamepage window
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            LoadLevel(Directory.GetCurrentDirectory() + "\\Resources\\Levels\\Floor_1.txt"); //load the first level
        }
    }
}
