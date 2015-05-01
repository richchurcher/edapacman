//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using EDAPacman.Model;
//using EDAPacman;

//namespace EDAPacman.DAL
//{
//    public class SaveController
//    {
//        public void Process(string command, IEnumerable<string> args)
//        {
//            //Create Add model
//            Maze model = new Maze();
//            model.SaveGame(args);
            
//            BoardView _viewBoard = new BoardView();

//            model.Persist();
//            AddView view = new AddView();
//            view.Render(model);
//            //Tell Add Model to persist to db
//            //Prep message
//            //(Create a persist and prep message method on the Add model)
//            //Render view

//        }
//    }
//}
