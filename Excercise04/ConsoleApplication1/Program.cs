using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];
            InputInt(array);
        }
        public static void InputInt(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write("Phan tu - {0} : ", 1);
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static bool Findnum5(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {

                if (Arr[i] == 5)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Findnum5or6(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {

                if (Arr[i] == 5)
                {
                    return true;
                }
                else
                {
                    if (Arr[i] == 6)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool Findnum5and6(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {

                if (Arr[i] == 5 )
                {
                    for (int j = 0; j < Arr.Length; j++)
                    {
                        if (Arr[j] == 6)
                        {
                            return true;
                        }
                    }

                }
            }
            return false;
        }
    }
}
