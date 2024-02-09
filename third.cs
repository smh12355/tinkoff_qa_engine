using System;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace tinkoff_test_new
{
    internal class third
    {
        internal static void test()
        {
            int[] NLW = Array.ConvertAll<string,int>(Console.ReadLine().Split(' '),int.Parse);
            int[] x_coords = Array.ConvertAll<string,int>(Console.ReadLine().Split(' '),int.Parse);
            List<int> L = new List<int>();
            Array.Sort<int>(x_coords);
            for (int i = 0; i < x_coords.GetUpperBound(0); i++)
            {
                if (x_coords[i + 1] > x_coords[i] + NLW[2])
                {
                    L.Add(x_coords[i + 1]  - (x_coords[i] + NLW[2]));
                }
            }
            if (x_coords[0] != 0)
            {
                L.Add(x_coords[0]);
            }
            if (x_coords[^1] + NLW[2] != NLW[1])
            {
                L.Add(NLW[1] - (x_coords[^1] + NLW[2]));
            }
            int result = 0;
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i] % NLW[2] == 0)
                {
                    result += L[i] / NLW[2];
                }
                else
                {
                    result += (L[i] / NLW[2]) + 1;
                }
            }
            Console.WriteLine(result);
            
        }
    }
}
