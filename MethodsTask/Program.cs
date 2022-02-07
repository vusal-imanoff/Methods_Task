using System;
using System.Linq;

namespace MethodsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MaxValue
            //Console.WriteLine("how many number do you enter? ");
            //int lenght;
            //int.TryParse(Console.ReadLine(), out lenght);
            //int[] arr = new int[lenght];

            //Console.WriteLine($"\nMax value in numbers: " + MaxValue(arr, lenght));
            #endregion
            #region SumOfNumbers
            //Console.WriteLine("Enter Number");
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //Console.WriteLine($"Sum elements of number: "+SumOfNumbers(n));
            #endregion
            #region MarkenPresent
            //double[] arr = new double[3];
            //Console.WriteLine($"the price you will pay: "+MarketPresent(arr));
            #endregion


        }
        #region MaxValue
        static int MaxValue(int[] arr, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"Number -{i + 1} :", i);
                int.TryParse(Console.ReadLine(), out arr[i]);
            }
            Console.Write("\n Numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        #endregion
        #region SumOfNumbers
        // static int SumOfNumbers(int n)
        //{
        //    {
        //        int q = 0;
        //        int sum = 0;
        //        while (n != 0)
        //        {
        //            q = n % 10;
        //            n = n / 10;
        //            sum = sum + q;
        //        }
        //        return sum;
        //    }
        //}
        #endregion
        #region MarketPresent


        //static double MarketPresent(double[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write($"{i + 1}-Product: ",i);
        //        double.TryParse(Console.ReadLine(), out arr[i]);
        //    }
        //    double temp = arr[0];
        //    double sum = 0;
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (temp>arr[i])
        //        {

        //            sum = sum + temp;
        //            temp = arr[i];

        //        }
        //        else if (arr[i] > arr.Length-1)
        //        {
        //            sum = sum + arr[i];
        //        }
        //        else
        //        {
        //            sum = sum + (arr.Length-1);
        //        }

        //    }
        //    return sum;
        //}
        #endregion
    }
}
