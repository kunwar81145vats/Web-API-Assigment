using System;
using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests;

[TestClass]
public class MultiplicationUnitTest
{
    [DataTestMethod]
    [DataRow(1, 1, 1)]
    [DataRow(2, 2, 4)]
    [DataRow(2, 7, 14)]
    public void MultiplyWithPositiveInts(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "*");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(1, -1, -1)]
    [DataRow(4, -2, -8)]
    [DataRow(1, -2, -2)]
    public void MultiplyWithOneNegative(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "*");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, -1, 0)]
    [DataRow(0, -2, 0)]
    [DataRow(0, -5, 0)]
    public void MultiplyWithOneNegativeAndZero(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "*");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, 1, 0)]
    [DataRow(0, 2, 0)]
    [DataRow(0, 5, 0)]
    public void MultiplyWithZero(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "*");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(-2, -1, 2)]
    [DataRow(-1, -5, 5)]
    [DataRow(-4, -5, 20)]
    public void MultiplyWithNegativeInts(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "*");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(1.2, 1.5, 1.8)]
    [DataRow(2.1, 2.5, 5.2)]
    [DataRow(2.1, 7.1, 14.9)]
    public void MultiplyWithPositiveDoubles(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "*");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(1, -1.5, -1.5)]
    [DataRow(4, -2.2, -8.8)]
    [DataRow(1, -2.5, -2.5)]
    public void MultiplyWithOneNegativeDouble(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "*");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, -1.5, 0)]
    [DataRow(0, -2.3, 0)]
    [DataRow(0, -5.5, 0)]
    public void MultiplyWithOneNegativeDoubleAndZero(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "*");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, 1.5, 0)]
    [DataRow(0, 2.1, 0)]
    [DataRow(0, 5.5, 0)]
    public void MultiplyWithZeroAndDouble(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "*");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(-2.1, -1.2, 2.5)]
    [DataRow(-1.6, -5.1, 8.2)]
    [DataRow(-4.2, -5.4, 22.7)]
    public void MultiplyWithNegativeDouble(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "*");
        Assert.AreEqual(expected, result);
    }
}

