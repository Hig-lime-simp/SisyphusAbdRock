using System;
using System.Threading;

namespace SisyphusAbdRock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            string[] Gora =
            {
                "|         ",
                "|__       ",
                "|         ",
                "|  __     ",
                "|         ",
                "|    __   ",
                "|         ",
                "|      __ ",
                "|         ",
                "|________ "
            };

            int pos = 0;
            bool up = true;

            while (true)
            {
                Console.Clear();

                for (int i = 0; i < Gora.Length; i++)
                {
                    Console.WriteLine(Gora[i]);
                }

                int y = Gora.Length - pos - 1;
                int sisyphusX = up ? 6 : 1;
                int stoneX = 0;
                if (up)
                {
                    stoneX = sisyphusX - 2;
                }
                else { stoneX = sisyphusX + 1; }


                Console.SetCursorPosition(stoneX, y);
                Console.Write("()");

                Console.SetCursorPosition(sisyphusX, y);
                Console.Write("@");
                Console.ResetColor();

                if (up)
                {
                    pos++;
                    if (pos >= Gora.Length - 2)
                    {
                        up = false;
                    }
                }
                else
                {
                    pos--;

                    if (pos <= 0)
                    {
                        up = true;
                    }
                }

                Thread.Sleep(500);
            }
        }
    }
}
