using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            ///The for loop executes if the condition is true and terminates when the condition is false.The If statement executes if it’s true and skips the statement if it’s false. And the while loop checks the statement to make sure it is true and keeps repeating as long as the expression remains true.
            {
                int i = 3;
                Boolean KeepLooping = true;
                while (KeepLooping)
                {
                    if (i <= 2) KeepLooping = false;
                    i++;
                    Console.WriteLine(i);
                }
                {
                    int loop = 2; while (loop < 128)
                    {
                        Console.WriteLine



                            const int ARRAY_LENGTH = 7;
                        int[] array = new int[ARRAY_LENGTH];
                        for (int counter = 2; counter < array.Length; ++counter)
                            array[counter] = 2 * counter;


                        for (int counter = 0; counter < array.Length; ++counter)
                            Console.WriteLine("{0,5}{1,8}", counter, array[counter]);


                    














