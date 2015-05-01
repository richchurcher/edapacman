using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EDAPacman
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Router router = new Router();
            router.Route(args);
            /*/
            Controller controller = new Controller();
            controller.Game();
            
        }
    }
}
