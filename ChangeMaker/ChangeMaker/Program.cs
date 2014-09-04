using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {


            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);

            Console.ReadKey();
        }
        static void ChangeMaker(double amount)
    {


        List<string> coinList = new List<string>() { "Quarter", "Dime", "Nickle", "Penny"};



        double Quarter = amount / .25;
        double Dime = amount / .10;
        double Nickle = amount / .05;
        double Penny = amount / .01;

        Console.WriteLine("$" + amount);
        Console.WriteLine(Quarter + " " + "Quarter");
        Console.WriteLine(Dime + " " + "Dime");
        Console.WriteLine(Nickle + " " + "Nickle");
        Console.WriteLine(Penny + " " + "Penny");


            
    }
    }
}
