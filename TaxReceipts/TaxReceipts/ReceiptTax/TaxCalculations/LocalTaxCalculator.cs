using TaxReceipts.utils;


namespace TaxReceipts.TaxCalculations
{
    public class LocalTaxCalculator : ITaxCalculator
    // It Calculates Total Tax Cost According to Local Region Specification.
    {
        public double CalculateTax(double price, double localTax, bool imported)
        {
            double tax = price * localTax;

            if (imported)
                tax += (price * 0.5);

          
            tax = TaxUtil.RoundOff(tax);  //rounds off to nearest 0.05;

            return tax;
        }
    }
}
