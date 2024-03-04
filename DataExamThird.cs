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
            List<HashSet<int>> Pairs = new List<HashSet<int>>();
            for (int i = 0; i < amount; i++)
            {
                int[] exmp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                HashSet<int> set = new HashSet<int>();
                for (int j = exmp[0]; j <= exmp[1]; j++)
                {
                    set.Add(j);
                }
                Pairs.Add(set);
            }
            int length = 0;
            foreach (HashSet<int> set in Pairs)
            {
                length += set.Count - 1;
            }
            HashSet<int> intersections = new HashSet<int>(Pairs[0]);
            for (int i = 1; i < amount; i++)
            {
                intersections.IntersectWith(Pairs[i]);
            }
            if (intersections.Count() != 0)
            {
                length += intersections.Count() - 1;
            }
            for (int i = 0; i < amount - 1; i++)
            {
                for (int j = i + 1; j < amount; j++)
                {
                    if (Pairs[i].Intersect(Pairs[j]).Count() == 0)
                    {
                        continue;
                    }
                    else
                    {
                        length -= Pairs[i].Intersect(Pairs[j]).Count() - 1;
                    }
                }
            }
            Console.WriteLine(length);
        }
    }
}
