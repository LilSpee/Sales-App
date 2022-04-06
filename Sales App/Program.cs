using System;

namespace Sales_App
{
    class Program
    {

        public Program()
        {
        
        }
        
        static void Main(string[] args)
        {
            double Item1price = 239.99;
            double Item2price = 129.75;
            double Item3price = 99.95;
            double Item4price = 350.89;

            Console.WriteLine("How many of item 1 did you sell?");
            double item1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("How many of item 2 did you sell?");
            double item2 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("How many of item 3 did you sell?");
            double item3 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("How many of item 4 did you sell?");
            double item4 = Convert.ToInt32(Console.ReadLine());

            double Total1 = Item1price * item1;
            double Total2 = Item2price * item2;
            double Total3 = Item3price * item3;
            double Total4 = Item4price * item4;
            double Totalall = Total1 + Total2 + Total3 + Total4 * .09 + 200;

            Console.WriteLine(Totalall);
            
        }
    }
}
