using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {


        static void Main(string[] args)
        {
            foreach (var item in ReverseInt(4434221))
            {
                Console.Write(item);
            }
        }



        public static List<int> ReverseInt(int a)
        {
            List<int> reversed = new List<int>();

            int leftInt = a / 10;
            int rightInt = a % 10;

            reversed.Add(rightInt);

            while (leftInt > 9)
            {

                rightInt = leftInt % 10;
                leftInt = leftInt / 10;
                reversed.Add(rightInt);

            }
            reversed.Add(leftInt);
            return reversed;
        }

    }
}
