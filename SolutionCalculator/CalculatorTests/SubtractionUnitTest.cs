using System;
using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests;

[TestClass]
public class SubtractionUnitTest
{
    [DataTestMethod]
    [DataRow(1, 1, 0)]
    [DataRow(2, 2, 0)]
    [DataRow(2, 7, -5)]
    public void SubtractionWithPositiveInts(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "-");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(1, -1, 2)]
    [DataRow(4, -2, 6)]
    [DataRow(0, -2, 2)]
    public void SubtractionWithOneNegative(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "-");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, -1, 1)]
    [DataRow(0, -2, 2)]
    [DataRow(0, -5, 5)]
    public void SubtractionWithOneNegativeAndZero(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "-");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, 1, -1)]
    [DataRow(0, 2, -2)]
    [DataRow(0, 5, -5)]
    public void SubtractionWithZero(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "-");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(-2, -1, -1)]
    [DataRow(-1, -5, 4)]
    [DataRow(-4, -5, 1)]
    public void SubtractionWithNegativeInts(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "-");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(1.2, 1.5, -0.3)]
    [DataRow(2.1, 2.5, -0.4)]
    [DataRow(2.1, 7.1, -5.0)]
    public void SubtractionWithPositiveDoubles(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "-");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(1, -1.5, 2.5)]
    [DataRow(4, -2.2, 6.2)]
    [DataRow(1, -2.5, 3.5)]
    public void SubtractionWithOneNegativeDouble(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "-");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, -1.5, 1.5)]
    [DataRow(0, -2.3, 2.3)]
    [DataRow(0, -5.5, 5.5)]
    public void SubtractionWithOneNegativeDoubleAndZero(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "-");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, 1.5, -1.5)]
    [DataRow(0, 2.1, -2.1)]
    [DataRow(0, 5.5, -5.5)]
    public void SubtractionWithZeroAndDouble(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "-");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(-2.1, -1.2, -0.9)]
    [DataRow(-1.6, -5.1, 3.5)]
    [DataRow(-4.2, -5.4, 1.2)]
    public void SubtractionWithNegativeDouble(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "-");
        Assert.AreEqual(expected, result);
    }
}


