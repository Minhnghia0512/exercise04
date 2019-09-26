using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise04
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static bool IsOdd(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }
        static bool IsEven(int n)
        {
            if (n % 2 != 0)
            {
                return true;
            }
            return false;
        }
        static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static int Square(int n)
        {
            int nSqr = 0;
            return nSqr = n*n;
        }
        static int Cube(int n)
        {
            int ncu = 0;
            return ncu = n * n * n;
        }
        static int Pow(int x, int y)
        {
            if (y == 0) return 1;
            if (y == 1) return x;
            int a = y / 2;
            int xa = Pow(x, a);
            if (a + a == y) 
                return xa * xa;
            else
                return xa * xa * x;
        }
        static int Abs(int n)
        {
            return ((n < 0) ? (-n) : (n));
        }
        static 

    }
}
