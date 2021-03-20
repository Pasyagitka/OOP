using System;
using Lab05.Decorator;
namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat flat1 = new EmptyFlat();
            flat1 = new DecoratedFlat(flat1);
            Console.WriteLine(flat1.Name + " cost: " + flat1.GetCost());
            
            flat1 = new FurnitureFillFlat(flat1);
            Console.WriteLine(flat1.Name + " cost: " + flat1.GetCost());
            
            Flat flat2 = new EmptyFlat();
            flat2 = new FurnitureFillFlat(flat2);
            Console.WriteLine(flat2.Name + " cost: " + flat2.GetCost());
        }
    }
}
