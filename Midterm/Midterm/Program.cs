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


                        int counter = 2;
                        while (counter < 129)
                        {
                            Console.WriteLine("[{0}]", counter++);
                        }
                        {
                            for (int x = 49; x > 0; x--)
                            {
                                Console.Write("{0}{1}", x, x == 1 ? "" : "");
                            }
                            Console.WriteLine();
                        }
                        {
                            counter = 0;
                            while (counter < 22)
                            {

                                Console.Write("{0}", counter % 2 != 0 ? counter + "" : "");
                                counter++;
                            }
                            Console.WriteLine();
                        }
                        ///The do-while loop will run while checking if the condition is true. A do-while loop prints a *even though the statement condition is not true.

                        ///The while loop checks whether the condition is true or false before running. A while loop would not print a "*" because 10 is not less than 8. 

                    }
                    bool icyRain = false;
                    bool tornadoWarning = false;

                    if (icyRain == false || tornadoWarning == false)

                    {
                        Console.WriteLine("Let's go outside!");
                    }
                    {
                        for (int row = 0; row < 5; row++)
                        {

                            for (int space = 0; space < row; space++)
                            {
                                Console.Write(" ");
                            }

                            for (int num = 0; num < 5 - row;)
                            {
                                Console.Write(++num);
                            }

                            for (int num = 5 - row; num > 1;)
                            {
                                Console.Write(--num);
                            }

                            for (int space = 0; space < row; space++)
                            {
                                Console.Write(" ");
                            }

                            Console.WriteLine();
                        }

                        Console.ReadKey(true);

                    }
                }
                    }
                }
            }
        }
    

                    














