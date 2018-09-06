using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class _26
    {
        public int RemoveDuplicates(int[] nums) {
            //for(int i = nums.Length-1; i >= 0; i--)
            //{
            //    if(nums[i] == nums[i - 1])
            //    {
            //        nums = DeleteArr
            //    }
            //}
            nums = nums.Distinct().ToArray();
            for(int i = 0; i < nums.Length;i++)
            {
                Console.WriteLine(nums[i]);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2 };
            _26 pro = new _26();
            pro.RemoveDuplicates(nums);
            Console.ReadKey();
        }
    }
}
