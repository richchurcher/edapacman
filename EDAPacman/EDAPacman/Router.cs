using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDAPacman.DAL;

namespace EDAPacman
{
    internal class Router
    {
        public void Route(string[] args)
        {
            var command = args.Length != 0 ? args[0].ToLowerInvariant() : String.Empty;
            switch (command)
            {
                case "save":
                 SaveController addController = new SaveController();
                    break;
                // TODO Implement the list controller and list view so they retrieve from the database and show the list of todos in the console
                case "list":
                ListController listcontroller = new ListController();
                    break;
                case "fetch":
                  FetchController fetchcontroller = new FetchController();
                    break;
                case "deleteboard":
                    DeleteController delete = new DeleteController();
                    break;
                default:
                    Controller controller = new Controller();
                    break;
                    


            }
        }
    }
}

