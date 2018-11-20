using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            ///The 4 basic elements needed for the counter-controlled repetition are the control variable, initial value, increment (decrement) and the loop-continuation condition. The control variable is also called a loop counter. The initial value is the starting point of the control variable, increment or decrement is how the control variable is modified each time it loops, and the loop continuation condition is determines if the script should continue to loop or not.
            /// <summary>

            /// <summary>
            ///A “for” and “while” statement are almost the same. They both do operate the same but a “for” statement is a more condensed version of a “while” statement. A “while” statement would be 
            ///Int i = 0 
            ///While(i < 10) 
            ///Console.writeline(i);
            //i++
        }
        ///A “for” statement would be written as:
        ///For(int i = 0; i < 10; i++)
        ///{
        ///Console.writeline(i);
    }
    /// <summary>

    /// <summary>
    ///It's appropriate to use a do-while statement when you need something to be done at least once and you don’t know the number of times before initiating the loop.
    /// <summary>
    // For-loop that outputs odd and even using System;
    public class Forcounter
    {
        public static void Main(string[] args)
        {
            for (inti = 1; i <= 100; ++i) // loop 100 times
            {
                Console.WriteLine(i);
                if ((i % 2) == 0) // it’s even
                    Console.Write("{0}", "It's even");
                else//it's odd
                    Console.Write("{0}", "It's odd");
            }//end for
        }//end Main
        public static int i { get; set; }
    }//end class


{
    static void Main(string[] args)
    {
        Console.Write("Please enter a temperature: ");

        int temp = Convert.ToInt32(Console.ReadLine());

        if (temp >= 90) { Console.WriteLine("fish"); }

        else if (temp >= 80) { Console.WriteLine("Lion"); }

        else if (temp >= 70) { Console.WriteLine("Turle"); }

        else if (temp >= 60) { Console.WriteLine("Deer"); }

        else if (temp >= 50) { Console.WriteLine("Reindeer"); }

        else if (temp >= 40) { Console.WriteLine("Moose"); }

        else if (temp >= 20) { Console.WriteLine("Penguin"); }

        else if (temp >= 10) { Console.WriteLine("Polar Bear"); }

        else { Console.WriteLine("Bug"); }
    }
}

for (int i=0; i< 101; i++)
    
    {
    Console.WriteLine(i);
    Console.WriteLine("********");
    }

