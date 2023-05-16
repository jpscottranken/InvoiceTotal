using System;
using static System.Console;

namespace InvoiceTotalConsole01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal subtotal;
            decimal discountPct = 0m;
            decimal discountAmt;
            decimal invoiceTotal;

            Write("Please enter a subtotal now: ");
            subtotal = Convert.ToDecimal(Console.ReadLine());

            if (subtotal >= 500)
            {
                discountPct = 0.2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPct = 0.15m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPct = 0.1m;
            }

            discountAmt  = subtotal * discountPct;
            invoiceTotal = subtotal - discountAmt;

            Clear();
            WriteLine("Subtotal:\t\t"         + subtotal.ToString("c"));
            WriteLine("\nDiscount %:\t\t"     +  discountPct.ToString("p1"));
            WriteLine("\nDiscount Amount:\t"  + discountAmt.ToString("c"));
            WriteLine("\nTotal:\t\t\t"        + invoiceTotal.ToString("c"));

            ReadLine();
        }
    }
}
