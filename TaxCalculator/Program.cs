using System;
using System.Collections.Generic;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double total;
            double calculateTax;

            var inputOne = new List<productDetails>();
            var inputTwo = new List<productDetails>();
            var inputThree = new List<productDetails>();

            productInput shoppingTill = new productInput();
            printReceipt printingMachine = new printReceipt();

            Console.Write(" --------- INPUT 1 ---------\n");
            shoppingTill.EnterProductDetails(inputOne, 3);
            Console.Write(" --------- INPUT 2 ---------\n");
            shoppingTill.EnterProductDetails(inputTwo, 2);
            Console.Write(" --------- INPUT 3 ---------\n");
            shoppingTill.EnterProductDetails(inputThree, 4);

            total = 0;
            calculateTax = 0;

            Console.Write(" --------- OUTPUT 1 ---------\n");
            printingMachine.printing(inputOne, total, calculateTax);
            Console.Write(" --------- OUTPUT 2 ---------\n");
            printingMachine.printing(inputTwo, total, calculateTax);
            Console.Write(" --------- OUTPUT 3 ---------\n");
            printingMachine.printing(inputThree, total, calculateTax);
        }
    }
}
