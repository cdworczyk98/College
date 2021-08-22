using System;
using System.Windows;
using System.IO;

namespace GameSokoban
{
    class OpenFile
    {
        public int[,] Level { get; set; } //holds the integers read from the level text file

        public OpenFile()
        {
            Level = new int[15, 15]; //creates the array with 15x15 blank spaces
        }

        public bool LoadFile(string path) //takes the path of the file to read
        {
            string input = File.ReadAllText(path); //reads the entire text file into a string

            int i = 0, j = 0;

            try
            {
                foreach (var row in input.Split('\n')) //split the string at an enter key (rows)
                {
                    j = 0;
                    foreach (var col in row.Trim().Split(' ')) //splits the row further every blank space
                    {
                        Level[i, j] = int.Parse(col.Trim()); //parses the string into the Level array at x and y
                        j++;
                    }
                    i++;
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Level could not be loaded, Error: " + e); //display error if level couldn't be loaded
            }

            return false;
        }
    }
}
