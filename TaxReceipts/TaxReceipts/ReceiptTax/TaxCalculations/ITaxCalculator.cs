
namespace TaxReceipts.TaxCalculations
{
    
    public interface ITaxCalculator
    // Total Tax Cost of a Product.
    {

        double CalculateTax(double price, double tax, bool imported);
    }
}
