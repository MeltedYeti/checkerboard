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
                for (int j = 0; j < c; j++) // col
                {
                    for (int k = 0; k < h; k++) // height
                    {
                        for (int l = 0; l < c; l++) // col
                        {
                            for (int m = 0; m < w; m++) // width
                            {
                                sb.Append(v);
                            }
                            //sb.Append("/n");
                            v = SwitchChar(v);
                        }
                        sb.AppendLine();
                    }
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

        protected class Board
        {
            public int Columns { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }
    }
}
