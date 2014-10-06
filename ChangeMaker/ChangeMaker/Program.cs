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

            //call your ChangeMaker function
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);
            //keep the window open
            Console.ReadKey();
        }
        //create a function ChangeMaker with a double interger of amount
        static void ChangeMaker(double amount)
    {

            //create a list of the types of Currency types
        List<string> coinList = new List<string>() { "Quarter", "Dime", "Nickle", "Penny"};


            //assign each Currency type a value
        double Quarter = amount / .25;
        double Dime = amount / .10;
        double Nickle = amount / .05;
        double Penny = amount / .01;
//write the amoutn of each currency needed for the amount of money given.
        Console.WriteLine("$" + amount);
        Console.WriteLine(Quarter + " " + "Quarter");
        Console.WriteLine(Dime + " " + "Dime");
        Console.WriteLine(Nickle + " " + "Nickle");
        Console.WriteLine(Penny + " " + "Penny");


            
    }
    }
}
