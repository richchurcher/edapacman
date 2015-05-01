//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using EDAPacman.DAL;

//namespace EDAPacman
//{
//    internal class Router
//    {
//        public void Route(string[] args)
//        {
//            var command = args.Length != 0 ? args[0].ToLowerInvariant() : String.Empty;
//            switch (command)
//            {
//                case "save":
//                    SaveController controller = new SaveController();
//                    break;
//                // TODO Implement the list controller and list view so they retrieve from the database and show the list of todos in the console
//                case "list":
//                    ListController controller = new ListController();
//                    break;
//                case "fetch":
//                    FetchController controller = new FetchController();
//                    break;
//                case "deleteboard":
//                    DeleteController controller = new DeleteController();
//                    break;
//                default:
//                    Controller controller = new Controller();
//                    break;
//            }
//            try
//            {
//                controller.Process(command, args.Skip(1));
//            }
//            catch (Exception)
//            {
                
//                throw;
//            }




//        }
//        }
//    }
//}

