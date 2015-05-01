using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAPacman
{
    public class MazeView
    {
        public void CreateMaze(List<List<string>> maze)
        {

            for (int i = 0; i < maze.Count; i++)
            {
                for (int j = 0; j < maze.Count; j++)
                {
                    Console.WriteLine(maze[i][j]);
                }
                if (i == 19)
                {
                    Console.Write(" \n");
                }
                else
                {
                    Console.Write("\n");
                }
            }
        }

        public void ClearMaze()
        {
            Console.Clear();
        }

        public void DisplaySaveGame()
        {
            Console.WriteLine("You have saved the game; ");
        }
}
        }
    
