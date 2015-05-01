//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using EDAPacman.Model;

//namespace EDAPacman
//{
//    public class ListController
//    {
//        public void Process(string command, string[] args)
//        {
//            //Create Add model
//            Maze model = new Maze();
//            var listgames = model.ListGames();

//            MazeView _viewBoard = new MazeView();
//            _viewBoard.ClearMaze();
//            _viewBoard.ListAllGames(listgames);

//            Controller controller = new Controller();
//            controller.Game();

//        }
//    }
//}