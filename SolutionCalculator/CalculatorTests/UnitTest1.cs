using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorTests;

[TestClass]
public class UnitTest1
{
    [DataTestMethod]
    [DataRow(1, 1, 2)]
    [DataRow(2, 2, 4)]
    [DataRow(0, 2, 2)]
    [DataRow(2, 7, 9)]
    [DataRow(10, 3, 13)]
    [DataRow(7, 1, 8)]
    [DataRow(7, 4, 11)]
    [DataRow(2, 15, 17)]
    [DataRow(2, 3, 5)]
    [DataRow(71, 15, 86)]
    [DataRow(27, 15, 42)]
    [DataRow(7, 25, 32)]
    public void CalculatorAddTestMethod(int left, int right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "+");
        Assert.AreEqual(expected, result);
    }


    [DataTestMethod]
    [DataRow(1, 1, 0)]
    [DataRow(2, 1, 1)]
    [DataRow(10, 2, 5)]
    [DataRow(12, 7, 5)]
    [DataRow(10, 3, 7)]
    [DataRow(17, 15, 2)]
    [DataRow(17, 5, 2)]
    [DataRow(27, 15, 12)]
    [DataRow(20, 5, 15)]
    [DataRow(17, 8, 9)]
    [DataRow(17, 10, 7)]
    public void CalculatorMinusTestMethod(int left, int right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "-");
        Assert.AreEqual(expected, result);
    }


    [DataTestMethod]
    [DataRow(1, 1, 1)]
    [DataRow(2, 2, 1)]
    [DataRow(10, 2, 5)]
    [DataRow(2, 1, 2)]
    [DataRow(10, 5, 2)]
    [DataRow(7, 1, 7)]
    [DataRow(42, 4, 21)]
    [DataRow(27, 9, 3)]
    [DataRow(77, 11, 7)]
    [DataRow(70, 5, 40)]
    [DataRow(72, 2, 36)]
    public void CalculatorDivideTestMethod(int left, int right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "/");
        Assert.AreEqual(expected, result);
    }



    [DataTestMethod]
    [DataRow(1, 1, 1)]
    [DataRow(2, 2, 4)]
    [DataRow(0, 2, 0)]
    [DataRow(2, 7, 14)]
    [DataRow(10, 3, 30)]
    [DataRow(7, 15, 105)]
    [DataRow(2, 5, 10)]
    [DataRow(7, 5, 35)]
    [DataRow(7, 1, 1)]
    [DataRow(2, 15, 30)]
    [DataRow(4, 5, 20)]
    public void CalculatorMultiplyTestMethod(int left, int right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "*");
        Assert.AreEqual(expected, result);
    }
}
