
namespace Generics;

public class DiscountCalculator<TProduct> where TProduct : Product
{
    public float CalculatorDiscunt(TProduct product)
    {
        return product.Price;
    }
}
