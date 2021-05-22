using System;

namespace stringarray
{
  class Program
  {
    static void Main(string[] args)
    {

      // Array reference type 
      // The value can be accessed through indexes
      int[] firstArray;
      // Setup the array length
      firstArray = new int[10];

      string[] cars = { "Volvo", "Tesla", "Toyota", "Bugatti" };

      for (short i = 0; i < cars.Length; i++)
      {
        Console.WriteLine(cars[i]);
      }

      for (short i = 0; i <firstArray.Length; i++)
      {
          firstArray[i] = i;
          Console.WriteLine(firstArray[i]);
      }

        // Strings are array of characters 
        //We can access them through indexes but we can't change them;

      string anyString = "You're welcome";

      Console.WriteLine("The last letter of you're welcome is: " + anyString[anyString.Length - 1]);

    
    }
  }
}
