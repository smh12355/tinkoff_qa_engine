using System;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;

namespace tinkoff_test_new
{
    internal class third
    {
        internal static void test()
        {
            //int[] NLW = Array.ConvertAll<string,int>(Console.ReadLine().Split(' '),int.Parse);
            int[] NLW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] x_coords = Array.ConvertAll<string,int>(Console.ReadLine().Split(' '),int.Parse);
            int[] coords = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> L = new List<int>();
            Array.Sort<int>(coords);
            int amount = 0;
            if (coords[0] > NLW[2])
            {
                if (coords[0] % NLW[2] != 0)
                {
                    amount += (int)(coords[0] / NLW[2]) + 1;
                }
                else
                {
                    amount += (int)(coords[0] / NLW[2]);
                }
            }
            else if (coords[0] == 0)
            {}
            else
            {
                amount += 1;
            }
            if (coords[^1] + NLW[2] < NLW[1])
            {
                if ((NLW[1] - coords[^1]) % NLW[2] != 0)
                {
                    amount += ((int)((NLW[1] - coords[^1]) / NLW[2]) + 1) - 1;
                }
                else
                {
                    amount += (int)((NLW[1] - coords[^1]) / NLW[2]) - 1;
                }
            }
            else if (coords[^1] == NLW[1] - NLW[2])
            {}
            else
            {
            }
            if (NLW[0] == 2)
            {
                if ((coords[^1] - coords[0]) > NLW[2])
                {
                    if ((coords[^1] - coords[0]) % NLW[2] != 0)
                    {
                        amount += (int)((coords[^1] - coords[0]) / NLW[2]) + 1 - 1;
                    }
                    else
                    {
                        amount += (int)((coords[^1] - coords[0]) / NLW[2]) - 1;
                    }
                }
            }
            if (NLW[0] > 2)
            {
                for (int i = 0; i < coords.GetUpperBound(0); i++)
                {
                    if ((coords[i+1] - coords[i]) > NLW[2])
                    {
                        if ((coords[i + 1] - coords[i]) % NLW[2] != 0)
                        {
                            amount += (int)((coords[i + 1] - coords[i]) / NLW[2]) + 1 - 1;
                        }
                        else
                        {
                            amount += (int)((coords[i + 1] - coords[i]) / NLW[2] - 1);
                        }
                    }
                }

            }
        }
    }
}
