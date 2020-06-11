using System;
using System.Collections.Generic;

namespace TaxCalculator
{
    public class productInput
    {
        private char taxCommand;
        private char importCommand;
        private bool isImport = false;
        private bool isTax = false;

        public void EnterProductDetails(List<productDetails> productList, int count)
        {
            productDetails product = new productDetails();

            for (int i = 0; i < count; i++)
            {

                Console.Write("Enter Item:");
                product.item = Console.ReadLine();
                Console.Write("Enter Quantity:");
                product.quantity = int.Parse(Console.ReadLine());
                Console.Write("Import ? (y/n):");
                importCommand = char.Parse(Console.ReadLine());

                if (importCommand == 'y')
                {
                    isImport = true;

                }

                else if (importCommand == 'n')
                {
                    isImport = false;
                }

                Console.Write("Book ,Food or Medical ? (y/n):");
                taxCommand = char.Parse(Console.ReadLine());

                if (taxCommand == 'y')
                {
                    isTax = false;
                }

                else if (taxCommand == 'n')
                {
                    isTax = true;
                }

                Console.Write("Enter Price:");
                product.price = product.quantity * double.Parse(Console.ReadLine());
                Console.Write("\n");

                if (isTax && isImport)
                {
                    product.taxSales = product.price * 0.15;
                    product.price += product.taxSales;
                }

                else if (isTax)
                {
                    product.taxSales = product.price * 0.10;
                    product.price += product.taxSales;
                }

                else if (isImport)
                {
                    product.taxSales = product.price * 0.05;
                    product.price += product.taxSales;

                }

                productList.Add(new productDetails
                {
                    item = product.item,
                    quantity = product.quantity,
                    price = product.price,
                    taxSales = product.taxSales

                });

                product.taxSales = 0;
                product.item = "";
                product.price = 0;
                product.quantity = 0;
            }
        }
    }
}
