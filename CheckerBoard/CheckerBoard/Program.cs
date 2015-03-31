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
            var columns = 3;
            var rows = 4;
            var width = 3;
            var height = 1;

            
            var sb = new StringBuilder();

            for (int i = 0; i < rows; i++) // row
            {
                for (int j = 0; j < height; j++) // height
                {
                    var v = IsEven(i) ? 'x' : 'o';
                    for (int k = 0; k < columns; k++)
                    {
                        for (int l = 0; l < width; l++)
                        {
                            sb.Append(v);
                        }
                        v = ToggleChar(v);
                    }
                    sb.AppendLine();
                }
            }
            Console.Write(sb.ToString());
            Console.ReadLine();
        }

        private static char ToggleChar(char value)
        {
            var v = value == 'x' ? 'o' : 'x';
            return v;
        }

        private static bool IsEven(int i)
        {
            return i%2 == 1;
        }
    }
}
