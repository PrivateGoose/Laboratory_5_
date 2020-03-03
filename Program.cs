using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int test_number = int.Parse(input);
            string final_output = "";
            for (int test = 0; test < test_number; test++) //Almost all the variables have the noun "test" on them because of many tests i did and ended up not changing them by mistake, but now it's too late, the code it's  too big for that change
            {
                string number_string = Console.ReadLine();
                double number = int.Parse(number_string) + 1;
                bool condition_while = true;

                while (condition_while == true)
                {
                    int divided_number = 0;

                    while (divided_number < 1)
                    {
                        for (int i = 2; i <  Math.Ceiling(Math.Sqrt(number)); i++)//This method checks if n is a prime number.
                        {
                            if (number % i == 0)
                            {
                                divided_number += 1;//If the remainder is 0, add 1.
                            }
                        }
                        if (divided_number < 1)
                        {
                            number = number + 1; //If it's prime, redifine n, adding 1.
                        }
                    }
                    //If the number isn't prime, the program continues.


                    string number_string_2 = number.ToString();
                    int digitAddition = 0;
                    for (int variable = 0; variable < (number_string_2.Length); variable++)
                    {
                        int digits = int.Parse(number_string_2[variable].ToString());
                        digitAddition += digits;
                    }//This method calculates the addition of the digits of the number

                    
                    string factors = "";
                    double p = 2;
                    double temporal_number = number;

                    while (temporal_number >= p * p)
                    {
                        if (temporal_number % p == 0)
                        {
                            factors += p;
                            temporal_number = temporal_number / p;
                        }
                        else
                        {
                            p = p + 1;
                        }
                    }//This method calculates the addition of the prime factors of the number

                    factors += temporal_number;

                    int factorAddition = 0;
                    for (int y = 0; y < (factors).Length; y++)
                    {
                        int factor = int.Parse(factors[y].ToString());
                        factorAddition += factor;
                    }//Addition of the prime factors

                    if (digitAddition == factorAddition)
                    {
                        final_output += number + "\n";
                        condition_while = false;
                    }
                    else
                    {
                        number = number + 1;
                        condition_while = true;
                    }
                }
            }
            Console.WriteLine(final_output);
        }
    }
}
