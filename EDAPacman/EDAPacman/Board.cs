using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDAPacman
{
    public class Board
    {
        private List<List<string>> _board;
        private Player _player;
        private List<Trap> _traps;

        public Board()
        {
            _player = new Player(0, 0);
            CreateTraps();
            Refresh();
        }

        private void Wipe()
        {
            _board = new List<List<string>>(9)
            {
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
            };
        }

        private void CreateTraps()
        {
            _traps = new List<Trap>
            {
                new Trap(5,5),
                new Trap(4,7),
                new Trap(2,3),
                new Trap(6,2),
                new Trap(1,7),
            };
        }

        public bool CheckForTrap()
        {
            return _board[_player.Row][_player.Col] == ">";
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

            if (row >= 0 && row < _board.Count)
                _player.Row = row;
            if (col >= 0 && col < _board[0].Count)
                _player.Col = col;

            if (CheckForTrap())
                ResetPlayer();
            Refresh();
            return _board;


        }

        public void ResetPlayer()
        {
            _player.Row = 0;
            _player.Col = 0;
        }

        private void Refresh()
        {
            Wipe();
            _board[_player.Row][_player.Col] = _player.ToString();
            foreach (Trap t in _traps)
            {
                _board[t.Row][t.Col] = t.ToString();
            }
        }


        public bool CheckForWin()
        {
            return _player.Row == 8 && _player.Col == 8;

        }
        public List<List<string>> Get()
        {
            return _board;
        }

        public override string ToString()
        {
            string s = "";
            foreach (List<string> row in _board)
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