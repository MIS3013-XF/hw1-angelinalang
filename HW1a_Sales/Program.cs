// HW1a Sales Total

// Your Name: Angelina Q. Lang
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Sale Total

            // Declare: variables of this problem and their end format
            string Item;
            double Quantity;
            double Price;
            double Subtotal;
            const double TaxRate = .085;
            double SalesTax;
            double Total;

            // Prompt: Ask the user what item they are purchasing
            Console.WriteLine("What item are you purchasing? ");
            Item = Console.ReadLine();

            // Prompt: Ask the user the quantity of the item they are purchasing 
            Console.WriteLine("What is the quantity of this item? ");
            Quantity = Convert.ToDouble(Console.ReadLine());

            // Prompt: Ask the user how much the item was
            Console.WriteLine("How much did this item cost? ");
            Price = Convert.ToDouble(Console.ReadLine());

            // Calculate: subtotal
            Subtotal = Quantity * Price;

            // Calulate: sales tax 
            SalesTax = Subtotal * TaxRate;

            // Calculate: total 
            Total = Subtotal + SalesTax;

            // Print: end result 
            Console.WriteLine("The subtotal for your bill is " + Subtotal.ToString("C2") + ".");
            Console.WriteLine("The sales tax for your bill is " + SalesTax.ToString("C2") + ".");
            Console.WriteLine("The total for your bill is " + Total.ToString("C2") + ".");
            Console.ReadKey();
        }
    }
}
