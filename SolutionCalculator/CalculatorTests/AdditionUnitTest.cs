using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorTests;

[TestClass]
public class AdditionUnitTest
{
    
    [DataTestMethod]
    [DataRow(1, 1, 2)]
    [DataRow(2, 2, 4)]
    [DataRow(2, 7, 9)]
    public void AdditionWithPositiveInts(int left, int right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "+");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(1, -1, 0)]
    [DataRow(4, -2, 2)]
    [DataRow(0, -2, -2)]
    public void AdditionWithOneNegative(int left, int right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "+");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, -1, -1)]
    [DataRow(0, -2, -2)]
    [DataRow(0, -5, -5)]
    public void AdditionWithOneNegativeAndZero(int left, int right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "+");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, 1, 1)]
    [DataRow(0, 2, 2)]
    [DataRow(0, 5, 5)]
    public void AdditionWithZero(int left, int right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "+");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(-2, -1, -3)]
    [DataRow(-1, -5, -6)]
    [DataRow(-4, -5, -9)]
    public void AdditioWithNegativeInts(int left, int right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "+");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(1.2, 1.5, 2.7)]
    [DataRow(2.1, 2.5, 4.6)]
    [DataRow(2.1, 7.1, 9.2)]
    public void AdditionWithPositiveDoubles(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "+");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(1, -1.5, -0.5)]
    [DataRow(4, -2.2, 1.8)]
    [DataRow(1, -2.5, -1.5)]
    public void AdditionWithOneNegativeDouble(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "+");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, -1.5, -1.5)]
    [DataRow(0, -2.3, -2.3)]
    [DataRow(0, -5.5, -5.5)]
    public void AdditionWithOneNegativeDoubleAndZero(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "+");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, 1.5, 1.5)]
    [DataRow(0, 2.1, 2.1)]
    [DataRow(0, 5.5, 5.5)]
    public void AdditionWithZeroAndDouble(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "+");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(-2.1, -1.2, -3.3)]
    [DataRow(-1.6, -5.1, -6.7)]
    [DataRow(-4.2, -5.4, -9.6)]
    public void AdditioWithNegativeDouble(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "+");
        Assert.AreEqual(expected, result);
    }

}
