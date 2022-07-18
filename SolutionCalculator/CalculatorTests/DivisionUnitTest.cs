using System;
using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests;

[TestClass]
public class DivisionUnitTest
{
    [DataTestMethod]
    [DataRow(1, 1, 1)]
    [DataRow(2, 2, 1)]
    [DataRow(2, 7, 0.3)]
    public void DivideWithPositiveInts(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "/");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(1, -1, -1)]
    [DataRow(4, -2, -2)]
    [DataRow(1, -2, -0.5)]
    public void DivideWithOneNegative(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "/");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, -1, 0)]
    [DataRow(0, -2, 0)]
    [DataRow(0, -5, 0)]
    public void DivideWithOneNegativeAndZero(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "/");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, 1, 0)]
    [DataRow(0, 2, 0)]
    [DataRow(0, 5, 0)]
    public void DivideWithZero(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "/");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(-2, -1, 2)]
    [DataRow(-1, -5, 0.2)]
    [DataRow(-4, -5, 0.8)]
    public void DivideWithNegativeInts(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "/");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(1.2, 1.5, 0.8)]
    [DataRow(2.1, 2.5, 0.8)]
    [DataRow(2.1, 7.1, 0.3)]
    public void DivideWithPositiveDoubles(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "/");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(1, -1.5, -0.7)]
    [DataRow(4, -2.2, -1.8)]
    [DataRow(1, -2.5, -0.4)]
    public void DivideWithOneNegativeDouble(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "/");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, -1.5, 0)]
    [DataRow(0, -2.3, 0)]
    [DataRow(0, -5.5, 0)]
    public void DivideWithOneNegativeDoubleAndZero(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "/");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(0, 1.5, 0)]
    [DataRow(0, 2.1, 0)]
    [DataRow(0, 5.5, 0)]
    public void DivideWithZeroAndDouble(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "/");
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(-2.1, -1.2, 1.8)]
    [DataRow(-1.6, -5.1, 0.3)]
    [DataRow(-4.2, -5.4, 0.8)]
    public void DivideWithNegativeDouble(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, "/");
        Assert.AreEqual(expected, result);
    }


    [DataTestMethod]
    public void DivideDoubleWithZero()
    {
        Assert.ThrowsException<DivideByZeroException>(() => { Calculator.Calculate(8.5, 0, "/"); });
    }
}

