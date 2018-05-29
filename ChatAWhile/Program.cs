/********************************************************************
 * Original from SDEV 240                                           *
 * Coded by: Harley Ehrman                                          *
 *                                                                  *
 * From book:                                                       *
 * Microsoft Visual C# 2015:                                        *
 * An Introduction to Object-Oriented Programming 6th Edition       *
 * by Joyce Farrell                                                 *
 *                                                                  *
 * Instructions (Page 265, Exercise 6):                            *
 * The Chat-A-While phone company provides service to six area      *
 * codes and charges the per-minute rates for phone calls shown in  *
 * Figure 6-25. Write a program named ChatAWhile that stores the    *
 * area codes and rates in parallel arrays and allows a user to     *
 * enter an area code and the length of time for a call in minutes, *
 * and then display the total cost of the call.                     *
 *                                                                  *
 * Figure 6-35 Per-minute phone call rates                          *
 * Area Code   Per-Minute Rate ($)                                  *
 *   262           0.07                                             *
 *   414           0.10                                             *
 *   608           0.05                                             *
 *   715           0.16                                             *
 *   815           0.24                                             *
 *   920           0.14                                             *
 ********************************************************************/
using System;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare arrays and variables
            int[] area_code = { 262, 414, 608, 715, 815, 920 };
            double[] rates = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
            int userCode;
            double minutes;
            string inputString;
            int x;
            double rateAmount;
            double total;

            //show available area codes
            Console.WriteLine("Area Code List" + "\n" + "-------------");
            for (int i = 0; i < area_code.Length; i++)
            {
                Console.WriteLine(area_code[i]);
            }

            //get user input
            Console.Write("\n" + "Enter the area code from the above list: ");
            inputString = Console.ReadLine();
            userCode = Convert.ToInt32(inputString);
            Console.Write("Enter the length (in minutes) of the call: ");
            inputString = Console.ReadLine();
            minutes = Convert.ToDouble(inputString);

            //search for area code
            x = Array.BinarySearch(area_code, userCode);

            //get the rate
            rateAmount = rates[x];

            //calculate amount of call
            total = rateAmount * minutes;

            //display total cost
            Console.WriteLine("The total amount of the call is {0:C}", total);

            //stops program from automatically closing after above text displays.
            Console.ReadLine();
        }
    }
}
