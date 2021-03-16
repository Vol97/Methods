using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Methods.Tests
{
    class TwoDimensionalArraysTests
    {
        [TestCase(1, 10)]
        [TestCase(2, -9)]
        [TestCase(3, 0)]
        public void FindMinimumValueInATwoDimensionalArray_WhenArrayPassed_ReturnMinimumValueOfTheArray(int mockNumber, int expected)
        {
            int[,] array = TwoDimensionalArrayMock.GetTwoDimensionalArrayMock(mockNumber);

            int actual = TwoDimensionalArrays.FindMinimumValueInATwoDimensionalArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 99)]
        [TestCase(2, 9)]
        [TestCase(3, 0)]
        public void FindMaximumValueInATwoDimensionalArray_WhenArrayPassed_ReturnMaximumValueOfTheArray(int mockNumber, int expected)
        {
            int[,] array = TwoDimensionalArrayMock.GetTwoDimensionalArrayMock(mockNumber);

            int actual = TwoDimensionalArrays.FindMaximumValueInATwoDimensionalArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 0, 0 })]
        [TestCase(2, new int[] { 2, 2 })]
        [TestCase(3, new int[] { 0, 0 })]
        public void FindMinimumValueIndexInATwoDimensionalArray_WhenArrayPassed_ReturnIndexOfTheMinimumValueOfTheArray(int mockNumber, int[] expected)
        {
            int[,] array = TwoDimensionalArrayMock.GetTwoDimensionalArrayMock(mockNumber);

            int[] actual = TwoDimensionalArrays.FindMinimumValueIndexInATwoDimensionalArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 3, 2 })]
        [TestCase(2, new int[] { 1, 0 })]
        [TestCase(3, new int[] { 0, 0 })]
        public void FindMaximumValueIndexInATwoDimensionalArray_WhenArrayPassed_ReturnIndexOfTheMaximumValueOfTheArray(int mockNumber, int[] expected)
        {
            int[,] array = TwoDimensionalArrayMock.GetTwoDimensionalArrayMock(mockNumber);

            int[] actual = TwoDimensionalArrays.FindMaximumValueIndexInATwoDimensionalArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 4)]
        [TestCase(2, 3)]
        [TestCase(3, 0)]
        public void CountNumbersInAMatrixThatAreBiggerThanAllTheirNeighbours_WhenArrayPassed_ReturnNumberOfArrayElementsThatAreBiggerThanAllTheirNeighbours(int mockNumber, int expected)
        {
            int[,] array = TwoDimensionalArrayMock.GetTwoDimensionalArrayMock(mockNumber);

            int actual = TwoDimensionalArrays.CountNumbersInAMatrixThatAreBiggerThanAllTheirNeighbours(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 5)]
        [TestCase(2, 6)]
        [TestCase(3, 7)]
        public void TransposeAMatrix_WhenArrayPassed_ReturnATransposedMatrix(int mockNumber, int expectedMockNumber)
        {
            int[,] array = TwoDimensionalArrayMock.GetTwoDimensionalArrayMock(mockNumber);

            int[,] actual = TwoDimensionalArrays.TransposeAMatrix(array);

            int[,] expected = TwoDimensionalArrayMock.GetTwoDimensionalArrayMock(expectedMockNumber);

            Assert.AreEqual(expected, actual);
        }

        public static class TwoDimensionalArrayMock
        {
            public static int[,] GetTwoDimensionalArrayMock(int number)
            {
                int[,] result = new int[0, 0];

                switch (number)
                {
                    case 1:
                        result = new int[,]
                        {
                            { 10, 60, 80, 90, 10, 11, 76 },
                            { 40, 32, 93, 80, 11, 41, 51 },
                            { 31, 20, 63, 44, 95, 71, 40 },
                            { 64, 48, 99, 13, 11, 50, 16 },
                            { 13, 65, 78, 45, 14, 15, 16 }
                        };
                        break;
                    case 2:
                        result = new int[,]
                        {
                            { 1, 5, 8, 4 },
                            { 9, 7, 4, 1 },
                            { -8, 3, -9, 6 }
                        };
                        break;
                    case 3:
                        result = new int[,]
                        {
                            { 0, 0, 0 },
                            { 0, 0, 0 },
                            { 0, 0, 0 },
                            { 0, 0, 0 },
                        };
                        break;
                    case 4:
                        result = new int[,]
                        {
                            { 2, 6, 8, 0, 4, 3, 2, 1 },
                            { 2, 6, 8, 0, 4, 3, 2, 1 },
                            { 2, 6, 8, 0, 4, 3, 2, 1 },
                            { 2, 6, 8, 0, 4, 3, 2, 1 }
                        };
                        break;
                    case 5:
                        result = new int[,]
                        {
                            { 2,2,2,2 },
                            { 6,6,6,6 },
                            { 8,8,8,8 },
                            { 0,0,0,0 },
                            { 4,4,4,4 },
                            { 3,3,3,3 },
                            { 2,2,2,2 },
                            { 1,1,1,1 },
                        };
                        break;
                    case 6:
                        result = new int[,]
                        {
                            { 1, 9, -8},
                            { 5, 7, 3},
                            { 8, 4, -9},
                            { 4, 1, 6},
                        };
                        break;
                    case 7:
                        result = new int[,]
                        {
                            { 0, 0, 0, 0 },
                            { 0, 0, 0, 0 },
                            { 0, 0, 0, 0 }
                        };
                        break;
                }

                return result;
            }
        }
    }
}
