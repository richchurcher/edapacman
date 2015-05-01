
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDAPacman.Model;

namespace EDAPacman
{
    class Controller
    {
        public Maze _MainBoard { get; set; }
        public MazeView _view { get; set; }
        //public Player player { get; set; }
        public Keys _Keys { get; set; }

        public Controller()
        {
            _MainBoard = new Maze();
            //player = new Player(0, 0);
            _view = new MazeView();
            _view.ClearMaze();
            _view.CreateMaze(_MainBoard.Get());
            _Keys = new Keys();

        }
        public void MoveCharacter()
        {
            ConsoleKey inputCharacter = _Keys.ReadingKeys();
            if (inputCharacter == ConsoleKey.UpArrow || inputCharacter == ConsoleKey.DownArrow || inputCharacter == ConsoleKey.LeftArrow ||
               inputCharacter == ConsoleKey.RightArrow)
            {
                List<List<String>> updatedBoard = _MainBoard.MovePlayer(inputCharacter);
                _view.ClearMaze();
                _view.CreateMaze(updatedBoard);
            }
            else if (inputCharacter == ConsoleKey.S || inputCharacter == ConsoleKey.F || inputCharacter == ConsoleKey.Q || inputCharacter == ConsoleKey.L)


        }
        public void Game()
        {

            while (!_MainBoard.CheckForWin())
            {
                MoveCharacter();
            }
            
            var start = DateTime.UtcNow;
            while ((DateTime.UtcNow - start) < TimeSpan.FromSeconds(5))
            {
                Console.WriteLine("YOU WON THE GAME YEEEEAAAAAAAAAA!");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

    }
}