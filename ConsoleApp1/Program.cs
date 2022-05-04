using System;
using System.Linq;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums2 = new int[4] { 10, 2, 3, 3 };
            Console.WriteLine(HW1.QueueTime(nums2, 2));
            //int[] nums2 = new int[4] { 5, 3, 4, 1 };
            //Console.WriteLine(HW1.QueueTime(nums2, 1));

        }
    }

    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            var checkout = new int[n];

            foreach (var item in customers)
            {      
                checkout[Array.IndexOf(checkout, checkout.Min())] += item;
            }

            return checkout.Max();
        }
    }


}
