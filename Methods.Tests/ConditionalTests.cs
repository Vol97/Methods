using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Methods.Tests
{
    class ConditionalTests
    {
        [TestCase(2, 8, -6)]
        [TestCase(8, 8, 64)]
        [TestCase(8, 2, 10)]
        [TestCase(0, 0, 0)]
        public void ComparingABIfAisBiggerAddABIfAequalsBMultiplyElseAMinusB_WhenABPassed_ReturnAPlusBOrAMultipliedByBOrAMinusB(double a, double b, double expected)
        {
            double actual = Conditional.ComparingABIfAisBiggerAddABIfAequalsBMultiplyElseAMinusB(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, "1st quadrant")]
        [TestCase(1, -1, "4th quadrant")]
        [TestCase(-1, 1, "2nd quadrant")]
        [TestCase(-1, -1, "3rd quadrant")]
        [TestCase(0, 0, "The coordinate plane origin")]
        [TestCase(1, 0, "X axis")]
        [TestCase(0, 1, "Y axis")]
        public void FindingPlaceOnACoordinatePlane_WhenXYPassed_ReturnRightQuadrantForGivenCoordinatesXY(double x, double y, string expected)
        {
            string actual = Conditional.FindingPlaceOnACoordinatePlane(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(12d, 56d, 0d, 0d, 12d, 56d)]
        [TestCase(-47d, 0d, 65d, -47d, 0d, 65d)]
        [TestCase(0d, 0d, 0d, 0d, 0d, 0d)]
        [TestCase(-12d, -45d, -1d, -45d, -12d, -1d)]
        [TestCase(134d, 943d, -65d, -65d, 134d, 943d)]
        [TestCase(100d, 50d, 80d, 50d, 80d, 100d)]
        [TestCase(100d, 80d, 0d, 0, 80d, 100d)]
        public void AscendingNumberSorting_WhenABCPassed_ReturnABCSortedInAscendingOrder(ref double a, ref double b, ref double c, double expectedA, double expectedB, double expectedC)
        {
            Conditional.AscendingNumberSorting(ref a, ref b, ref c);

            double actualA = a;
            double actualB = b;
            double actualC = c;

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
            Assert.AreEqual(expectedC, actualC);
        }

        [TestCase(1, -2, -3, new double[] { 3, -1 })]
        [TestCase(-1, -2, 15, new double[] { -5, 3 })]
        [TestCase(1, 12, 36, new double[] { -6 })]
        [TestCase(1, 0, 36, new double[0])]
        [TestCase(1, -9, 0, new double[] { 9, 0 })]
        [TestCase(5, 2, 3, new double[0])]
        public void SolvingQuadraticEquation_WhenABCPassed_ReturnArrayWithQuadraticEquationSolutions(double a, double b, double c, double[] expected)
        {
            double[] actual = Conditional.SolvingQuadraticEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, "двенадцать")]
        [TestCase(-10, "минус десять")]
        [TestCase(99, "девяносто девять")]
        [TestCase(-23, "минус двадцать три")]
        public void TurnTwoDigitNumberIntoText_WhenNumberPassed_RepresentItAsTextAndReturnInString(int number, string expected)
        {
            string actual = Conditional.TurnTwoDigitNumberIntoText(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
