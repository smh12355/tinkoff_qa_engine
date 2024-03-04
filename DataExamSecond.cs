using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinkoff_test_new
{
    internal class DataExamSecond
    {
        internal static void test()
        {
            int amount = int.Parse(Console.ReadLine());
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            if (commands.Length != amount)
            {
                return;
            }
            for (int i = 0; i < commands.GetUpperBound(0); i++)
            {
                while (true)
                {
                    if (commands[i] != i + 1)
                    {
                        for (int j = i + 1; j <= commands.GetUpperBound(0); j++)
                        {
                            if (commands[i] > commands[j])
                            {
                                counter++;
                            }
                        }
                        break;
                        //counter++;
                        //int temp = commands[i];
                        //commands[i] = commands[temp - 1];
                        //commands[temp - 1] = temp;
                    }
                    else
                    {
                        break;
                    }

                }
            }
            Console.WriteLine(counter);
        }
    }
}
