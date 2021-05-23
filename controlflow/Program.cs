using System;

namespace controlflow
{
  class Program
  {

    static void Main(string[] args)
    {
      int grade = 9;
        string colour = "pirple";
      if (grade < 10)
      {
        Console.WriteLine("The student didn't admited to exame grade:  " + grade);
      }
      else if (grade >= 14)
      {
        Console.WriteLine("The student doesn't have to go throw exams grade: " + grade);
      }
      else
      {
        Console.WriteLine("The student admited to exame grade: " + grade);
      }

      switch (colour){
          case "green": Console.WriteLine("Green"); break;
          case "red": Console.WriteLine("Red"); break;
          case "yellow": Console.WriteLine("Yellow"); break;
          case "blue": Console.WriteLine("Blue"); break;
          case "alpha": Console.WriteLine("Alpha"); break;
          case "black": Console.WriteLine("Black"); break;
          case "white": Console.WriteLine("White"); break;
          case "pirple": Console.WriteLine("Pirple"); break;
      }
    }
    }
  }
