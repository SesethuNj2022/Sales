using TaxReceipts.Products;
using TaxReceipts.TaxCalculations;
using TaxReceipts.utils;
using System;
using System.Collections.Generic;


namespace TaxReceipts.Billing
{
    public class Biller
    {
        ITaxCalculator taxCalculator;

        public Biller(ITaxCalculator taxCalc)
        {
            taxCalculator = taxCalc;
        }

        public double CalculateTax(double price, double tax, bool imported)
        {

            double totalProductTax = taxCalculator.CalculateTax(price, tax, imported);
            return totalProductTax;
        }

        public double CalcTotalProductCost(double price, double tax)
        {
            return TaxUtil.Truncate(price + tax);
        }

        public double CalcTotalTax(List<Product> prodList)
        {
            double totalTax = 0.0;

            foreach (Product p in prodList)
            {
                totalTax += (p.TaxedCost - p.Price);
            }

            return TaxUtil.Truncate(totalTax);
        }

        public double CalcTotalAmount(List<Product> prodList)
        {
            double totalAmount = 0.0;

            foreach (Product p in prodList)
            {
                totalAmount += p.TaxedCost;
            }

            return TaxUtil.Truncate(totalAmount);
        }

        public Receipt CreateNewReceipt(List<Product> productList, double totalTax, double totalAmount)
        {
            return new Receipt(productList, totalTax, totalAmount);
        }

        public void GenerateReceipt(Receipt r)
        {
            string receipt = r.ToString();
            Console.WriteLine(receipt);
        }

    }
}
