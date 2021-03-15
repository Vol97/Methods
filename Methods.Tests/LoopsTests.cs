using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Methods.Tests
{
    class LoopsTests
    {
        [TestCase(-2, -2, 0.25)]
        [TestCase(2, 2, 4)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(3, -4, 0.012345679012345678)]
        [TestCase(10, 3, 1000)]
        [TestCase(-10, 3, -1000)]
        public void RaiseAToPowerB_WhenABPassed_ReturnARaisedToPowerB(double a, double b, double expected)
        {
            double actual = Loops.RaiseAToPowerB(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1000, new int[] { 1000 })]
        [TestCase(-100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        [TestCase(20, new int[] { 20, 40, 60, 80, 100, 120, 140, 160, 180, 200, 220, 240, 260, 280, 300, 320, 340, 360, 380, 400, 420, 440, 460, 480, 500, 520, 540, 560, 580, 600, 620, 640, 660, 680, 700, 720, 740, 760, 780, 800, 820, 840, 860, 880, 900, 920, 940, 960, 980, 1000 })]
        [TestCase(50, new int[] { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000 })]
        public void ReturnArrayOfNumbersFrom1to1000ThatCanBeDividedByN_WhenNPassed_ReturnAnArrayWithNumbersFrom1To1000ThatCanBeDividedByN(int n, int[] expected)
        {
            int[] actual = Loops.ReturnArrayOfNumbersFrom1to1000ThatCanBeDividedByN(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, new int[] { 1, 2, 3 })]
        [TestCase(100, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [TestCase(-100, new int[0])]
        [TestCase(35, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(0, new int[0])]
        public void ReturnArrayOfNumbersThatWhenRaisedToPower2AreLessThanN_WhenNPassed_ReturnArrayOfNumbersThatWhenRaisedToPower2AreLessThanN(int n, int[] expected)
        {
            int[] actual = Loops.ReturnArrayOfNumbersThatWhenRaisedToPower2AreLessThanN(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-10, 10)]
        [TestCase(5, 1)]
        [TestCase(10, 5)]
        [TestCase(100, 50)]
        [TestCase(256, 128)]
        public void ReturnTheBiggestDividerOfN_WhenNPassed_ReturnTheBiggestDividerOfN(int n, int expected)
        {
            int actual = Loops.ReturnTheBiggestDividerOfN(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-10, 14, 14)]
        [TestCase(7, 49, 196)]
        [TestCase(-14, -1, -21)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 5, 0)]
        [TestCase(-5, 5, 0)]
        public void ReturnSumOfNumbersInRangeFromAtoBThatCanBeDividedBy7WithoutRemainder_WhenABPassed_ReturnSumOfNumbersInRangeFromAtoBThatCanBeDividedBy7WithoutRemainder(int a, int b, int expected)
        {
            int actual = Loops.ReturnSumOfNumbersInRangeFromAtoBThatCanBeDividedBy7WithoutRemainder(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(5, 5)]
        [TestCase(10, 55)]
        public void ReturnNumberNFromFibonacciSequence_WhenNPassed_ReturnNumberNFromFibonacciSequence(int n, int expected)
        {
            int actual = Loops.ReturnNumberNFromFibonacciSequence(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 5, 5)]
        [TestCase(9, 0, 9)]
        [TestCase(25, 80, 5)]
        [TestCase(-25, 80, 5)]
        [TestCase(-25, -80, 5)]
        [TestCase(8, 8, 8)]
        public void FindGreatestCommonDivisorOfAandB_WhenABPassed_ReturnGreatestCommonDivisorOfAB(int a, int b, int expected)
        {
            int actual = Loops.FindGreatestCommonDivisorOfAandB(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 3)]
        [TestCase(8, 2)]
        [TestCase(64, 4)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        public void FindCubicRootOfPositiveN_WhenPositiveNPassed_ReturnCubicRootOfN(int n, int expected)
        {
            int actual = Loops.FindCubicRootOfPositiveN(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(73647, 3)]
        [TestCase(8364, 1)]
        [TestCase(18364, 2)]
        [TestCase(-135, 3)]
        [TestCase(-10, 1)]
        [TestCase(10, 1)]
        [TestCase(0, 0)]
        [TestCase(13, 2)]
        public void FindOddDigitsInN_WhenNPassed_ReturnQuantityOfOddDigitsInN(int n, int expected)
        {
            int actual = Loops.FindOddDigitsInN(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(74839, 93847)]
        [TestCase(-123, -321)]
        [TestCase(0, 0)]
        [TestCase(12, 21)]
        public void ReturnMirrorNumber_WhenNPassed_ReturnMirrorNumber(int n, int expected)
        {
            int actual = Loops.ReturnMirrorNumber(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34, 36, 38, 40, 41, 42, 43, 44, 46, 48, 56, 58, 60, 61, 62, 63, 64, 65, 66, 68, 78, 80, 81, 82, 83, 84, 85, 86, 87, 88 })]
        [TestCase(-10, new int[] { 2, 4, 6, 8 })]
        [TestCase(0, new int[0])]
        public void ReturnNumbersInRangeFrom1toNWhereSumOfEvenDigitsIsBiggerThanSumOfOdd_WhenNPassed_ReturnNumbersInRangeFrom1toNWhereSumOfEvenDigitsIsBiggerThanSumOfOdd(int n, int[] expected)
        {
            int[] actual = Loops.ReturnNumbersInRangeFrom1toNWhereSumOfEvenDigitsIsBiggerThanSumOfOdd(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, true)]
        [TestCase(0, 1, false)]
        [TestCase(-123, 543, true)]
        [TestCase(-123, -543, true)]
        [TestCase(356, 5, true)]
        [TestCase(356, -5, true)]
        public void FindOutIfAandBHaveSameDigitsInThem_WhenABPassed_ReturnTrueIfTheyHaveSameDigits(int a, int b, bool expected)
        {
            bool actual = Loops.FindOutIfAandBHaveSameDigitsInThem(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
