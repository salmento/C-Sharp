using System;

namespace stringarray
{
  //enums is used to declare a set of constants (value type)
  enum friends
  {
    Adil,
    Edson,
    Camoes,
    Yula
  }
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

      for (short i = 0; i < firstArray.Length; i++)
      {
        firstArray[i] = i;
        Console.WriteLine(firstArray[i]);
      }

      // Strings are array of characters 
      //We can access them through indexes but we can't change them;

      string anyString = "You're welcome";

      Console.WriteLine("The last letter of you're welcome is: " + anyString[anyString.Length - 1]);

      //enums is used to declare a set of constants (value type)
      friend(friends.Adil);
      static void friend(friends name)
      {

        if (friends.Adil == name )
        {
          Console.WriteLine("\n Sergio Adil Dulobo");
        } else if (friends.Camoes== name)
        {
          Console.WriteLine("\n Manuel Camoes");
        } else if (friends.Edson == name){
          Console.WriteLine("\n Edson Iranchadi");
        } else if (friends.Yula == name ) {
          Console.WriteLine("\n Yula Guivala");
        } else 
        {
          Console.WriteLine("\n Not recognised");
        }

      }


    }
  }
}
