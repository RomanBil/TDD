using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDs
{
    public class TDD
    {
        public int Discriminator(int a, int b, int c)
        {
            return b * b - (4 * a * c);
        }

        public int[] Work(int a, int b, int c)
        {
            //a*x*x+b*x+c=0

            int d = Discriminator(a, b, c);

            if (d >= 0)
            {
                int[] res = new int[2];

                res[0] = (-b + (int)Math.Sqrt(d)) / (2 * a);

                res[1] = (-b - (int)Math.Sqrt(d)) / (2 * a);

                return res;
            }

            else
            {
                return null;
            }
        }
    }
}
