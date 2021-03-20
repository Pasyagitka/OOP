using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Retailer r = new Retailer("Квартира1");
            r.Sell();
        }
    }
}