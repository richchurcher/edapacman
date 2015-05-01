
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDAPacman.Model;

namespace EDAPacman
{
    class Controller : IController
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
            ConsoleKey direction = _Keys.ReadingKeys();
            List<List<String>> updatedBoard = _MainBoard.MovePlayer(direction);
            _view.ClearMaze();
            _view.CreateMaze(updatedBoard);
        }
        public void Game()
        {

            while (!_MainBoard.CheckForWin())
            {
                MoveCharacter();
            }
            
            
            Console.WriteLine("YOU WON THE GAME");
            
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }


        public void Process(string command, string[] args)
        {
            Game();
        }
    }
}