namespace Guard;

public static class Argument
{
    public static double Positive(double value, string parameterName)
    {
        if (value <= 0)
        {
            throw new ArgumentException($"Argument {parameterName} is not positive.");
        }
        
        return value;
    }
}