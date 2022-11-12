using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tortik
{
    internal class css2
    {
        public int pos2 = 0;
        public int strelka()
        {
            ConsoleKeyInfo kay = Console.ReadKey();
            while (kay.Key != ConsoleKey.Enter)
            {

                if (kay.Key == ConsoleKey.UpArrow)
                {
                    pos2--;
                    if (pos2 < 0)
                        pos2 = 0;
                }
                else if (kay.Key == ConsoleKey.DownArrow)
                {
                    pos2++;
                    if (pos2 > 6)
                        pos2 = 6;
                }
                clear();
                Console.SetCursorPosition(0, pos2);
                Console.WriteLine("->");
                kay = Console.ReadKey();
            }
            return pos2;
        }

        private void clear()
        {
            if (pos2 > 0)
            {
                Console.SetCursorPosition(0, pos2 - 1);
                Console.WriteLine("  ");
            }
            if (pos2 < 7)
            {
                Console.SetCursorPosition(0, pos2 + 1);
                Console.WriteLine("  ");
            }
        }
    }
}