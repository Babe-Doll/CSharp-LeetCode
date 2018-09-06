using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Solution
    {
        public bool IsPalindrome(int x)
        {
            bool flag = true;
            string strx = x.ToString();
            int length = strx.Length;
            for (int i = 0; i < length/2; i++)
            {
                if(strx[i] != strx[length - i - 1])
                {
                    flag = false;
                    return flag;
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
        }
        static void Main(string[] args)
        {
            int nums = 1000021;
            Solution s = new Solution();
            Console.WriteLine(s.IsPalindrome(nums));
            Console.ReadKey();
        }
    }
}
