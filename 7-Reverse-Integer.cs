using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public int Reverse(int x)
        { 
            string strx = x.ToString();
            int result;
            int length = strx.Length;
            if (strx[0] == '-')
            {
                strx = strx.Substring(1,length-1);
                
                var revx = strx.Reverse().ToArray();
                string a = new string(revx);
                if (int.TryParse(a, out result))
                {
                    return -result;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                
                var revx = strx.Reverse().ToArray();
                string a = new string(revx);
                if (int.TryParse(a, out result))
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            

        }
        static void Main(string[] args)
        {
            int x = -1534236469;
            Program pro = new Program();
            int a  = pro.Reverse(x);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
