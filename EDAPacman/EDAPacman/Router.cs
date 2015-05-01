using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    controller = new AddController();
                    break;
                // TODO Implement the list controller and list view so they retrieve from the database and show the list of todos in the console
                case "showboards":
                    controller = new ListController();
                    break;
                case "fetch":
                    controller = new DeleteContoller();
                    break;
                case "deleteboard":
                    controller = new DeleteContoller();
                    break;


            }
        }
    }

