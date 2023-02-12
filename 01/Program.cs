using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            ConsoleKeyInfo cski;

            int x = 10;
            int y = 10;

            while(true)
            {
                Console.Clear();

                Console.SetCursorPosition(x, y);

                Console.Write("#");

                cski = Console.ReadKey(true);

                switch (cski.Key)
                {
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                }
                #endregion

            }
        }
    }
}
