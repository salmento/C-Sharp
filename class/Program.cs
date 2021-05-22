using System;

namespace classes
{
    // abstract class
    // cannot instantiated 
    // can contain abstract methods but its not required 
    // can contain non abstract metheods 
  public abstract class Car {
        public string name;
        public int numberOfWheel;
        public int speed;

        public abstract void print();

        public virtual void test(){
            Console.WriteLine("Worked");
        }

    }

    // Class are stored in Heap instead of stack so.
    // The stack store the reference Type of the class that it stored in the heap.
    // Class can compromise the performance of the software.
    // Class suport polymorphism and inheritance.
    // Class (reference types) hold a reference to the object 
    // Data members in classes by default are private whereas in structs are private
    public class Tesla: Car {
        public Tesla(){
            name = "Tesla";
            numberOfWheel = 4;
            speed = 225;
        }

        public override void print(){
            Console.WriteLine("Car name " + name);
            Console.WriteLine("This car as " + numberOfWheel + "Wheel");
            Console.WriteLine("The speed of this car is " + speed);
        }
    }

  // Structures(value types) hold their value in the memory  in the location shere they 
  // were declared 
  // Structures are similar to classes they can have public and private data
  // in structure we can have data members and functions.
  public struct Colour { 
        public string name;

        public Colour(string name){
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          new Tesla().print();  
          Colour Blue = new Colour("Blue");
          Console.WriteLine("The colour is " + Blue.name);
        }
    }
}
