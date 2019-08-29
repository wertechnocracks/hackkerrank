using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class DrawingBook
    {
        //https://www.hackerrank.com/challenges/drawing-book/problem

        internal void TakeInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());

            int result = pageCount(n, p);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private int pageCount(int n, int p)
        {
            int diiferenceFormFirstPage = p - 1, differenceFormLastPage = n - p, currentPage = 0, result = 0;

            if (n == p || p == 1)
            {
                return 0;
            }
            else if (diiferenceFormFirstPage < differenceFormLastPage)
            {
                currentPage = 1;
                do
                {
                    currentPage += 2;
                    result++;

                } while (!(currentPage >= p));
            }
            else
            {
                if (n % 2 == 0)
                {
                    currentPage = n + 1;
                }
                else
                {
                    currentPage = n;
                }

                while (currentPage <= p)
                {
                    currentPage -= 2;
                    result++;
                }

            }

            return result;
        }
    }
}
