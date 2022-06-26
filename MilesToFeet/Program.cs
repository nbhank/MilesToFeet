/*
Design an application that converts miles to feet. Declare and initialize miles to
4.5. Show your miles formatted with two positions to the right of the decimal.
Feet and inches should both be shown with no positions to the right of the
decimal. Once you get that portion running, modify your solution so that you
also show the total number of inches. Go into your source code and change the
initialization value for miles. Rerun the application.
 1 mile = 5280 feet
 1 mile = 63360 inches
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToFeet
{
  class Program
  {
    static void Main(string[] args)
    {
      float miles = 4.5f;
      const int MILES_RATIO = 5280;
      const int INCHES_RATIO = 63360;
      
      Console.WriteLine("{0:F2} miles = {1} feet", miles, miles * MILES_RATIO);
      Console.WriteLine("{0:F2} miles = {1} inches", miles, miles * INCHES_RATIO);
    }
  }
}
