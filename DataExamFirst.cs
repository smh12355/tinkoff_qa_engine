using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinkoff_test_new
{
    internal class DataExamFirst
    {
        static internal void test()
        {
            char[] password = Console.ReadLine().ToArray();
            if (password.Length < 8)
            {
                Console.WriteLine("NO");
                return;
            }
            (int isascii, int isupper, int islower, int isnumber) = (0, 0, 0, 0);
            foreach (char c in password)
            {
                //if (char.IsAscii(c))
                //{
                //    flag1 = 1;
                //}
                //else
                //{
                //    Console.WriteLine("NO");
                //    return;
                //}
                if (c >= 0 && c <= 127)
                {
                    isascii = 1;
                    if (char.IsUpper(c) && isupper != 1)
                    {
                        isupper = 1;
                    }
                    if (char.IsLower(c) && islower != 1)
                    {
                        islower = 1;
                    }
                }
                //else
                //{
                //    Console.WriteLine("NO");
                //    return;
                //}
                if (char.IsNumber(c) && isnumber != 1)
                {
                    isnumber = 1;
                }
            }
            if (isascii == 1 && islower == 1 && isupper == 1 && isnumber == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
