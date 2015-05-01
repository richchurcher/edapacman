using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDAPacman.Migrations;

namespace EDAPacman
{
    public interface IController
    {
        void Process(string command, string[] args);
    }
}
