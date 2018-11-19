using System;

namespace whatDayOfTheWeekWasIt
{
    public class WhatDayOfTheWeekWasIt
    {
        public void ReturnDay()
        {
            Console.WriteLine("Enter a date and I'll tell you what day of the week it was!");
            var userInput = Console.ReadLine();
            DateTime result;
            DateTime.TryParse(userInput, out result);

            if (!result.Equals(DateTime.MinValue))
            {
                Console.WriteLine(result.DayOfWeek.ToString());
            }
            else {
                Console.WriteLine("Oops! Not a valid date. Try again please.");
            }
        }
    }
}
