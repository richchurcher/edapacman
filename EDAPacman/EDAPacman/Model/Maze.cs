using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDAPacman.Model
{
    public class Maze
    {
        private List<List<string>> maze;
        private Player _player;
       

        public Maze()
        {
            _player = new Player(0, 0);
       
            Refresh();
        }

        private void Wipe()
        {
            maze = new List<List<string>>(20);
            //{
                
                //new List<string>(20) (),
                //new List<string>(20) (),
                //new List<string>(20) (),
                //new List<string>(20) (),
                //new List<string>(20) (),
                //new List<string>(20) (),
                //new List<string>(20) (),
                //new List<string>(20) (),
                //new List<string>(20) (),
                                    
            // };
        }

    

        public bool CheckForTrap()
        {
            return maze[_player.Row][_player.Col] == ">";
        }

        public List<List<string>> MovePlayer(ConsoleKey key)
        {
            int row = _player.Row;
            int col = _player.Col;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    row--;
                    break;
                case ConsoleKey.DownArrow:
                    row++;
                    break;
                case ConsoleKey.LeftArrow:
                    col--;
                    break;
                case ConsoleKey.RightArrow:
                    col++;
                    break;
            }

            if (row >= 0 && row < maze.Count)
                _player.Row = row;
            if (col >= 0 && col < maze[0].Count)
                _player.Col = col;

            if (CheckForTrap())
                ResetPlayer();
            Refresh();
            return maze;


        }

        public void ResetPlayer()
        {
            _player.Row = 0;
            _player.Col = 0;
        }

        private void Refresh()
        {
            Wipe();
            maze[_player.Row][_player.Col] = _player.ToString();
            foreach (Trap t in _traps)
            {
                maze[t.Row][t.Col] = t.ToString();
            }
        }


        public bool CheckForWin()
        {
            return _player.Row == 8 && _player.Col == 8;

        }
        public List<List<string>> Get()
        {
            return maze;
        }

        public override string ToString()
        {
            string s = "";
            foreach (List<string> row in maze)
            {
                foreach (string square in row)
                {
                    s += square;
                }
                s += "\n";
            }
            return s;
        }

    }
}