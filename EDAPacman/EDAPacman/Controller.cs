using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDAPacman
{
    class Controller
    {
        public Maze _MainBoard { get; set; }
        public BoardView _view { get; set; }
        //public Player player { get; set; }
        public Keys _Keys { get; set; }

        public Roguelike_Controller()
        {
            _MainBoard = new Maze();
            //player = new Player(0, 0);
            _view = new BoardView();
            _view.ClearBoard();
            _view.CreateBoard(_MainBoard.Get());
            _Keys = new Keys();

        }

        public void MoveCharacter()
        {
            ConsoleKey direction = _Keys.ReadingKeys();
            List<List<String>> updatedBoard = _MainBoard.MovePlayer(direction);
            _view.ClearBoard();
            _view.CreateBoard(updatedBoard);

        }

        public void Game()
        {

            while (!_MainBoard.CheckForWin())
            {
                MoveCharacter();
            }
            //YOU WON!!!!!
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