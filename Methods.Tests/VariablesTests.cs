using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Methods.Tests
{
    class VariablesTests
    {
        [TestCase(2, 8, 12.333333333333334)]
        [TestCase(-9, -278, -287.13382899628255)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, -5)]
        [TestCase(-8, 8, 1.5)]
        public void SolveEquation_WhenAandB_ThenReturnSolutionOfEquation(double a, double b, double expected)
        {
            double actual = Variables.SolveEquation(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2d, 8d, 8d, 2d)]
        [TestCase(4d, 6d, 6d, 4d)]
        [TestCase(0d, 0d, 0d, 0d)]
        [TestCase(-6d, 8d, 8d, -6d)]
        [TestCase(1236d, -8376d, -8376d, 1236d)]
        public void SwapVariables_WhenAandB_SwapAandB(ref double a, ref double b, double expectedA, double expectedB)
        {
            Variables.SwapVariables(ref a, ref b);

            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        }

        [TestCase(10, 5, new double[] { 2, 0 })]
        [TestCase(5, 10, new double[] { 0.5, 5 })]
        [TestCase(452, 11, new double[] { 41.09090909090909, 1 })]
        [TestCase(-10, 5, new double[] { -2, 0 })]
        [TestCase(0, 5, new double[] { 0, 0 })]
        public void DivideAndFindRemainder_WhenAandB_ReturnResultOfDivisionAndRemainderInAnArray(double a, double b, double[] expected)
        {
            double[] actual = Variables.DivideAndFindRemainder(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 8, 6, -0.4)]
        [TestCase(-8, 100, -13, 14.125)]
        [TestCase(1, 0, 0, 0)]
        [TestCase(-1, -40, -7, -33)]
        public void SolveLinearEquation_WhenAandBandC_ReturnSolutionOfLinearEquation(double a, double b, double c, double expected)
        {
            double actual = Variables.SolveLinearEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 13, 11, 2, "y = -3,6666666666666665x + (42,33333333333333)")]
        [TestCase(-34, 137, -3411, 0, "y = 0,040568551969203434x + (138,3793307669529)")]
        [TestCase(374, 1, -1, 93, "y = -0,24533333333333332x + (92,75466666666667)")]
        [TestCase(10, 8, 12, 6, "y = -1x + (18)")]
        public void MakeEquationOfALine_WhenX1andY1andX2andY2_ReturnEquationOfALineAsAString(double x1, double y1, double x2, double y2, string expected)
        {
            string actual = Variables.MakeEquationOfALine(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }
    }

}
