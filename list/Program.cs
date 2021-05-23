using System;
using System.Collections.Generic;

namespace list
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> cities = new List<string>();
      cities.AddRange(new string[] { "Maputo", "Xai Xai", "Matola", "Maxixe", "Beira" });
      cities.RemoveAt(1);
      cities.Add("Xai Xai");
      Console.WriteLine(cities.Contains("Matola"));
      cities.ForEach( city => Console.WriteLine(city));
    }
  }
}
