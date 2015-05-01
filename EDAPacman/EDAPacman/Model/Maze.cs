using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EDAPacman.Plumbing;

namespace EDAPacman.Model
{
    public class Maze
    {
        public int Id { get; set; }
        public string Layout { get; set; }
        public Player Player { get; set; }
        private List<List<string>> _maze; 
       

        public Maze()
        {
           
            Layout =
               "====================" +
               "=..................=" +
               "=.================.=" +
               "=.====.............=" +
               "=.====.======.====.=" +
               "=.====.======.====.=" +
               "=.====........====.=" +
               "=...==.======.==...=" +
               "===.==.======.==.===" +
               "===.==.======.==.===" +
               "=..................=" +
               "=.====.===.==.====.=" +
               "=.====.===.==.====.=" +
               "=......===.==......=" +
               "=.====.===.==.====.=" +
               "=.====.==.===.====.=" +
               "=.====.==.===.====.=" +
               "=.==......===...==.=" +
               "=.==.====.=====.==.=" +
               "=....====.=====....=" +
               "===================="; 

            
            Player = new Player(0, 0);
       
            //Refresh();
        }

        public void Save()
        {
            GameContext context = new GameContext();
            context.SaveChanges();
        }

        private void Wipe()
        {
            Layout =
                "====================" +
                "=..................=" +
                "=.================.=" +
                "=.====.............=" +
                "=.====.======.====.=" +
                "=.====.======.====.=" +
                "=.====........====.=" +
                "=...==.======.==...=" +
                "===.==.======.==.===" +
                "===.==.======.==.===" +
                "=..................=" +
                "=.====.===.==.====.=" +
                "=.====.===.==.====.=" +
                "=......===.==......=" +
                "=.====.===.==.====.=" +
                "=.====.==.===.====.=" +
                "=.====.==.===.====.=" +
                "=.==......===...==.=" +
                "=.==.====.=====.==.=" +
                "=....====.=====....=" +
                "====================";  
        }

        //public bool CheckForTrap()
        //{
        //    return _maze[_player.Row][_player.Col] == ">";
        //}

        //public List<List<string>> MovePlayer(ConsoleKey key)
        //{
        //    int row = _player.Row;
        //    int col = _player.Col;

        //    switch (key)
        //    {
        //        case ConsoleKey.UpArrow:
        //            row--;
        //            break;
        //        case ConsoleKey.DownArrow:
        //            row++;
        //            break;
        //        case ConsoleKey.LeftArrow:
        //            col--;
        //            break;
        //        case ConsoleKey.RightArrow:
        //            col++;
        //            break;
        //    }

        //    if (row >= 0 && row < _maze.Count)
        //        _player.Row = row;
        //    if (col >= 0 && col < _maze[0].Count)
        //        _player.Col = col;

        //    if (CheckForTrap())
        //        ResetPlayer();
        //    Refresh();
        //    return _maze;


        //}

        //public void ResetPlayer()
        //{
        //    _player.Row = 0;
        //    _player.Col = 0;
        //}

        //private void Refresh()
        //{
        //    Wipe();
        //    _maze[_player.Row][_player.Col] = _player.ToString();
        //    foreach (Trap t in _traps)
        //    {
        //        _maze[t.Row][t.Col] = t.ToString();
        //    }
        //}


        //public bool CheckForWin()
        //{
        //    return _player.Row == 8 && _player.Col == 8;

        //}
        //public List<List<string>> Get()
        //{
        //    return _maze;
        //}

        //public override string ToString()
        //{
        //    string s = "";
        //    foreach (List<string> row in _maze)
        //    {
        //        foreach (string square in row)
        //        {
        //            s += square;
        //        }
        //        s += "\n";
        //    }
        //    return s;
        //}

    }
}