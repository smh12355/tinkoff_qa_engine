using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinkoff_test_new
{
    internal class DataExamThird
    {
        internal static void test()
        {
            int amount = int.Parse(Console.ReadLine());
            SortedList<int,int> points = new SortedList<int,int>();
            for (int i = 0; i < amount; i++)
            {
                int[] exmp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                points.Add(exmp[0], 1);
                points.Add(exmp[1], 0);
            }
            (int Balance, int Lenght, int Initial) = (1, 0, points.Keys[0]);
            for (int i = 1; i < points.Count; i++)
            {
                if (points.Values[i] == 1 && (Balance != 0))
                {
                    Balance++;
                }
                else if (points.Values[i] == 0)
                {
                    Balance--;
                }
                else
                {
                    Balance++;
                    Initial = points.Keys[i];
                }

                if (Balance == 0)
                {
                    Lenght += -1 * (Initial - points.Keys[i]);
                }

            }
            Console.WriteLine(Lenght);
            //for (int i = 1; i < amount; i++)
            //{
            //    intersections.IntersectWith(Pairs[i]);
            //}
            //if (intersections.Count() != 0)
            //{
            //    length += intersections.Count() - 1;
            //}
            //for (int i = 0; i < amount - 1; i++)
            //{
            //    for (int j = i + 1; j < amount; j++)
            //    {
            //        if (Pairs[i].Intersect(Pairs[j]).Count() == 0)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            length -= Pairs[i].Intersect(Pairs[j]).Count() - 1;
            //        }
            //    }
            //}
            //Console.WriteLine(length);
        }
    }
}
