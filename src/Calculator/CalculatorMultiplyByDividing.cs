namespace Calculator;

public class CalculatorMultiplyByDividing : IMultiplierService
{
    public float Multiply(float arg1, float arg2)
    {
        return arg1 / (1 / arg2);
    }
}
