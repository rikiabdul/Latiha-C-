using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoUse_the_increment_operator_before_and_after_the_value
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine("Second: " + value++);
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));
        }
    }
}
