using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab
{
    // IT1050
    class Program
    {
        public static bool Temperature { get; private set; }

        static void Main(string[] args)
        {




            int SpeedLimit;
            int Speed;

            SpeedLimit = 35;
            Speed = 42;

            if (Speed > SpeedLimit)


                Console.WriteLine("SLOW NOW");



            int isTrue;
            isTrue = 10;
            if (isTrue <= 60)
                Console.WriteLine("It is True");
            else
                Console.WriteLine("It is False");

            Console.WriteLine("Input temperature in Fahrenheit: ");
            int fah = int.Parse(Console.ReadLine());

            int FtoC = ((fah - 32) / 9) * 5;
            Console.WriteLine("The Celsius value is {0}: ", FtoC);

            if (fah >= 90)


                Console.WriteLine("It is hot");
            if (fah <= 40)
                Console.WriteLine("It is cold");

            int i = 1;
            while (i < 11)

                Console.Write("While Output: ");
            Console.WriteLine(i);

            while (60 >= 20)

                Console.Write("While Output: ");

        }
    }
}





/// <summary>
/// They both perform action(s) based on whether the condition is true or false. If the condition is true, the if single-selection statement performs the action once. The while repetition statement repeadedly performs the actions until the condition is false.
/// </summary> 