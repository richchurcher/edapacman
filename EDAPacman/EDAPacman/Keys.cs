using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDAPacman
{
    public class Keys
    {
        public ConsoleKey ReadingKeys()
        {
            var key = Console.ReadKey().Key;
            bool keepReading = true;

            while (keepReading)
            {
                if (key == ConsoleKey.RightArrow)
                {
                    return key;
                }
                if (key == ConsoleKey.LeftArrow)
                {
                    return key;
                }
                if (key == ConsoleKey.UpArrow)
                {
                    return key;
                }
                if (key == ConsoleKey.DownArrow)
                {
                    return key;
                }
                if (key == ConsoleKey.Q)
                {
                    keepReading = false;
                }
                if (key == ConsoleKey.S)
                {
                    // some logic in here to interact with database.
                }
                else
                {
                    Console.WriteLine(" Please use the arrow keys");
                    keepReading = false;
                    ReadingKeys();
                }
            }

            return key;
        }
    }
}