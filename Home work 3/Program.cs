using System;

namespace Home_work_3
{

  enum catName
  {
    Fancy
  }
  class Program
  {
    static void Main(string[] args)
    {
      byte catEars = 2;
      short catEyes = 2;
      int catPaws = 4;
      long catFur = 2000000;
      float catHeight = 0.5F;
      double catWeight = 3.4;

      string[] catColors = { "Blue", "Black", "White" };

      Console.WriteLine("The cat as " + catEars + " Ears");
      Console.WriteLine("The cat as " + catEyes + " Ears");
      Console.WriteLine("The cat as " + catPaws + " Ears");
      Console.WriteLine("The cat as " + catFur + " Ears");
      Console.WriteLine("The cat as " + catHeight + " Ears");
      Console.WriteLine("The cat as " + catWeight + " Ears");

      for (int i = 0; i < catColors.Length; i++)
      {
        short aux = (short)(i + 1);
        Console.WriteLine("The cat color number " + (aux) + " is : " + catColors[i]);
      }
        catName name = catName.Fancy;
      if(catName.Fancy == name) {
          Console.WriteLine(name + " is my cat");
      } else {
          Console.WriteLine(name + " isn't my cat");
      }
    }
  }
}
