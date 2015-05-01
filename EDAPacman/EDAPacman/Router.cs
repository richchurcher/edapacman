using System;
using System.Collections.Generic;
using System.Linq;

using System;
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

            IController controller;
            var command = args.Length != 0 ? args[0].ToLowerInvariant() : String.Empty;
            switch (command)
            {
                case "save":
                    controller = new SaveController();
                    break;
                case "list":
                    controller = new ListController();
                    break;
                case "fetch":
                    controller = new FetchController();
                    break;
                case "deleteboard":
                    controller = new DeleteController();
                    break;
                default:
                    controller = new Controller();
                    break;
            }

            controller.Process(command, args.Skip(1).ToArray());


        }
    }
}


