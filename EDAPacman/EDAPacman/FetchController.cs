﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDAPacman.Model;

namespace EDAPacman
{
    public class FetchController : IController
    {
        public void Process(string command, string[] args)
        {
            //Create Add model
            Maze model = new Maze();
            var fetchgame = model.Load(id);

            MazeView _viewBoard = new MazeView();
            _viewBoard.ClearMaze();
            _viewBoard.CreateMaze(fetchgame);

            Controller controller = new Controller();
            controller.Game();

        }

      
    }
}