using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public static class Variables
    {
        public static double SolveEquation(double a, double b)
        {
            if (a == b)
            {
                throw new Exception("b - a = 0, can't divide by zero");
            }

            return (5 * a + b * b) / (b - a);
        }

        public static void SwapVariables(ref double a, ref double b)
        {
            double swapVariable;

            swapVariable = a;
            a = b;
            b = swapVariable;
        }

        public static double[] DivideAndFindRemainder(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("can't divide by zero");
            }

            double[] divisionResultAndRemainder = new double[2] { a / b, a % b };

            return divisionResultAndRemainder;
        }

        public static double SolveLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("can't solve the equation if a = 0");
            }

            double x = (c - b) / a;

            return x;
        }

        public static string MakeEquationOfALine(double x1, double y1, double x2, double y2)
        {
            if (x2 - x1 == 0)
            {
                throw new Exception("x2 - x1 = 0, can't divide by zero");
            }

            string equationOfALine = $"y = {(y2 - y1) / (x2 - x1)}x + ({-(x1 * y2 - x1 * y1) / (x2 - x1) + y1})";

            return equationOfALine;
        }

    }
}
