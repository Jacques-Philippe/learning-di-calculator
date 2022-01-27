namespace Calculator;

public class Calculator
{
    private IAdderService _Adder;
    private IMultiplierService _Multiplier;

    public Calculator(IAdderService adder, IMultiplierService multiplier)
    {
        _Adder = adder;
        _Multiplier = multiplier;
    }

    public float Add(float arg1, float arg2) => _Adder.Add(arg1, arg2);

    public float Multiply(float arg1, float arg2) => _Multiplier.Multiply(arg1, arg2);
}
