namespace CalculatorLibrary;
public class Calculator
{
    //Method for calculations
    public static double Calculate(double lValue, double rValue, string symbol)
    {
        double response = 0;

        switch (symbol)
        {
            //Addition
            case "+":
                response = lValue + rValue;
                break;

            //Subtraction
            case "-":
                response = lValue - rValue;
                break;

            //Division
            case "/":
                if(rValue == 0)
                {
                    throw new DivideByZeroException("Divide by 0 not possible");
                }
                else
                {
                    response = lValue / rValue;
                }
                break;

            //Multiplication
            case "*":
                response = lValue * rValue;
                break;
        }

        return Math.Round(response, 1);
    }
}

