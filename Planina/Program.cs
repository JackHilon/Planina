using System;

namespace Planina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Planina
            // https://open.kattis.com/problems/planina 
            // (recursive problem -- divide a square to 4 squares)

            Console.WriteLine(PointsSquare(PointsRow(EnterNum())));
        }
        private static int PointsSquare(int n)
        {
            return n * n;
        }

        private static int PointsRow(int n)
        {
            if (n == 0)
                return 1;
            else if (n == 1)
                return 3;
            else
            {
                return 2* PointsRow(n - 1) -1;
            }
        }

        private static int EnterNum()
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                if (a < 1 || a > 15)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterNum();
            }
            return a;
        }
    }
}
