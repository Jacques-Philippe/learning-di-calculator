namespace CalculatorService;

public class CalculatorNegativeAdder : IAdderService
{
    public float Add(float arg1, float arg2)
    {
        return arg1 - -arg2;
    }
}
