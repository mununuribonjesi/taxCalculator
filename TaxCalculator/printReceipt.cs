using System;
using System.Collections.Generic;

namespace TaxCalculator
{
    public class printReceipt
    {    
        public void printing(List<productDetails> products,double total, double calculateTax)
        {
            foreach (var product in products)
            {
                Console.Write(product.quantity + "\t" + product.item + "\t" + string.Format("{0:F2}",Math.Round(product.price,2)+ "\n"));
                total += Math.Round(product.price,2);
                calculateTax += product.taxSales;
            }

            Console.Write("Sales Taxes:" + string.Format("{0:F2}",Math.Ceiling(calculateTax * 20)/20) + "\n");
            Console.Write("Total:" + string.Format("{0:F2}",Math.Round(total,2,MidpointRounding.ToEven) +"\n"));
        }
    }
}
