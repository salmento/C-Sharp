using System;

namespace homework4
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 1; i <= 100; i++)
      {
        int count = 0;
        if (i % 2 != 0)
        {
          int j;
          for (j = 1; j <= i; j++)
          {
            if (i % j == 0)
            {
              count++;
            }
          }
        }
        if (i == 2)
        {
          Console.WriteLine(i + ": Prime");
        }
        else if (count == 2)
        {
          Console.WriteLine(i + ": Prime");
        }
        else if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine(i + ": FizzBuzz");
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine(i + ": Fizz");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine(i + ": Buzz");
        }
        else
        {
          Console.WriteLine(i);
        }

      }
    }
  }
}
