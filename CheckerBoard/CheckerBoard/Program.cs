using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckerBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = 5;
            var r = 4;
            var w = 3;
            var h = 3;

            var v = 'x';
            var sb = new StringBuilder();

            for (int i = 0; i < r; i++) // row
            {
                
                var t = 0;
                while (t < h)
                {
                    v = IsEven(i) ? 'x' : 'o';
                    var x = 0;
                    while (x < c)
                    {
                        for (int j = 0; j < w; j++)
                        {
                            sb.Append(v);
                        }
                        v = SwitchChar(v);
                        x++;
                    }
                    sb.AppendLine();
                    t++;
                }
            }
            Console.Write(sb.ToString());
            Console.ReadLine();
        }

        private static char SwitchChar(char value)
        {
            var v = value == 'x' ? 'o' : 'x';
            return v;
        }

        private static bool IsEven(int i)
        {
            return i%2 == 1;
        }

        protected class Board
        {
            public int Columns { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }
    }
}
