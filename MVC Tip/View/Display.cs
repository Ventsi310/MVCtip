using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Tip.View
{
    internal class Display
    {
        public double Amount { get; private set; }
        public double Percent { get; private set; }
        public double Total { get; set; }
        public double TipAmount { get; set; }

        public void Input()
        {
            Console.Write("Enter the price of the meal: ");
            Amount = double.Parse(Console.ReadLine());
            Console.Write("Enter the amount for percent: ");
            Percent = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("___________________________");
            Console.WriteLine($"Yor tip is: {TipAmount:C}");
            Console.WriteLine("___________________________");
            Console.WriteLine($"The total will be: {Total:C}");
            Console.WriteLine("___________________________");
        }
    }
}
