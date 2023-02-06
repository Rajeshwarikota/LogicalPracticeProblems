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
            int num = 0;
            Random random = new Random();

            Console.WriteLine("Enter how many Coupons Needed :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] coupon = new int[n];
            while (num < n)
            { 
                int rand = random.Next(1,100);
                count++;
                if (coupon.Contains(rand))
                {

                }
                else 
                {
                    coupon[num] = rand;
                    num++;
                }
            }
            Console.WriteLine("coupon Numbers are");
            foreach (int i in coupon)
            {
                Console.Write(" "+i);            
            }
            Console.WriteLine("\ncount = " +count);
        }
    }
}
