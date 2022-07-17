namespace CalculatorLibrary;
public class Calculator
{
    //Method for calculations
    public static double Calculate(int lValue, int rValue, string symbol)
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
                response = lValue / rValue;
                break;

            //Multiplication
            case "*":
                response = lValue * rValue;
                break;
        }

        return response;
    }
}

