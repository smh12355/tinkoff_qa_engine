using System;
using System.Text;
using System.Linq;

namespace tinkoff_test_new
{
    internal class first_another
    {
        internal static void test()
        {
            StringBuilder coord1 = new StringBuilder(Console.ReadLine());
            //string[] test = Console.ReadLine().Split();
            int[] test = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] test1 = new int[test.GetUpperBound(0)+1];
            // Array.ForEach<string>(test,s => test1[Array.IndexOf<string>(test, s)] = int.Parse(s));
            //int i = 0;
            //Array.ForEach<string>(test,s => 
            //{
            //    test1[i] = int.Parse(s);
            //    i++;
            //});
            (coord1[test[0]-1],coord1[test[1]-1]) = (coord1[test[1]-1],coord1[test[0]-1]);
            Console.WriteLine(coord1);
        }
    }
}
