using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Daily
{
   public class Program
    {
        static void Main(string[] args)
        {
            int input = 31337357;

            while (input != 1)
            {
                if (input % 3 == 0)
                {
                    input = input / 3;
                    WriteLine(input + " 0");
                }
                else if (input % 3 == 1)
                {
                    input = (input - 1);
                    input = input / 3;
                    WriteLine(input + " - 1");

                }
                else if (input % 3 == 2)
                {
                    input = input + 1;
                    input = input / 3;

                    WriteLine(input + " + 1");
                }

            }


            ReadLine();
        }
    }
}
