using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        
                        return new int[] { i, j };

                    }

                }
            }
            throw new ArgumentException();
        }
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            Program pro = new Program();

            int[] result = pro.TwoSum(nums, 9);
            Console.WriteLine("[{0},{1}]",result[0],result[1]);
            Console.ReadKey();
        }
    }
}
