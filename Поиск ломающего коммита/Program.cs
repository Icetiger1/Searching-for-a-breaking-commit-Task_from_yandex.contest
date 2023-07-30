using System;

namespace Поиск_ломающего_коммита
{
    internal class Program
    {
        static int n, m, i;
        static string res;

        static void Main(string[] args)
        {
            n = Convert.ToInt32(Console.ReadLine());
            int left = 1;
            int right = n;
            i = 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                res = Ask(mid);
                if (res == "1")
                {
                    left = mid + 1;
                }
                else if (res == "0")
                {
                    right = mid;
                    if (left == right)
                    {
                        right = mid - 1;
                        m = mid;
                        Console.WriteLine($"! {m}");
                        break;
                    }
                }
                i++;
            }
            Console.ReadKey();
        }
        static string Ask(int commit)
        {
            Console.WriteLine(commit + Environment.NewLine);
            Console.Out.Flush();
            res = Console.ReadLine();
            return res;
        }
    }
}
