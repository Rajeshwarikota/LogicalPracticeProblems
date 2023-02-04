using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingPractiseProblems
{
    class CouponNumber
    {
        public static void CouponGenerator()
        {
            int n;
            int count = 0;
            int k = 0;
            Random random = new Random();

            Console.WriteLine("Enter how many Coupons Needed :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] coupon = new int[n];
            while (k < n)
            { 
             int rand = random.Next(1,2000);
                count++;
                int check = Array.IndexOf(coupon, rand);
                if (check == -1)
                {
                    coupon[k] = rand;
                    k++;
                }
            }
            Console.WriteLine("Unique coupon Numbers are");
            foreach (int i in coupon)
            {
                Console.WriteLine(i);            
            }
            Console.WriteLine("Count of Random Numbers needed is " +count);
        }
    }
}
