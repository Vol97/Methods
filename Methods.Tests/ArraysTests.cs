using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Methods.Tests
{
    class ArraysTests
    {
        [TestCase(new int[] { 3, 7, 0, -4, 3, 5, 137, -857, 1 }, -857)]
        [TestCase(new int[] { -134, -57, -836, -57, -173, 17482 }, -836)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 4 }, 0)]
        [TestCase(new int[] { -1, 0, 1 }, -1)]
        public void FindMinimumValueInArray_WhenArrayPassed_ReturnMinimumValueOfTheArray(int[] array, int expected)
        {
            int actual = Arrays.FindMinimumValueInArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 7, 0, -4, 3, 5, 137, -857, 1 }, 137)]
        [TestCase(new int[] { -134, -57, -836, -57, -173, 17482 }, 17482)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 4 }, 4)]
        [TestCase(new int[] { -1, 0, 1 }, 1)]
        public void FindMaximumValueInArray_WhenArrayPassed_ReturnMaximumValueOfTheArray(int[] array, int expected)
        {
            int actual = Arrays.FindMaximumValueInArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 7, 0, -4, 3, 5, 137, -857, 1 }, 7)]
        [TestCase(new int[] { -134, -57, -836, -57, -173, 17482 }, 2)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 4 }, 0)]
        [TestCase(new int[] { -1, 0, 1 }, 0)]
        public void FindMinimumValueIndexInArray_WhenArrayPassed_ReturnIndexOfTheMinimumValueOfTheArray(int[] array, int expected)
        {
            int actual = Arrays.FindMinimumValueIndexInArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 7, 0, -4, 3, 5, 137, -857, 1 }, 6)]
        [TestCase(new int[] { -134, -57, -836, -57, -173, 17482 }, 5)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 4 }, 7)]
        [TestCase(new int[] { -1, 0, 1 }, 2)]
        public void FindMaximumValueIndexInArray_WhenArrayPassed_ReturnIndexOfTheMaximumValueOfTheArray(int[] array, int expected)
        {
            int actual = Arrays.FindMaximumValueIndexInArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 4, 6, 8, 34, 1, 8, 9, 0 }, 48)]
        [TestCase(new int[] { 8, 4, 56, 7, 3, 5, 9, -2, -45, -2, -6, 6 }, 18)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1 }, 0)]
        public void ReturnSumOfNumbersWithOddIndexes_WhenArrayPassed_ReturnSumOfNumbersWithOddIndexes(int[] array, int expected)
        {
            int actual = Arrays.ReturnSumOfNumbersWithOddIndexes(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { -1, -2, -3 }, new int[] { -3, -2, -1 })]
        [TestCase(new int[] { 0, 0, 0, -1 }, new int[] { -1, 0, 0, 0 })]
        public void ReverseArray_WhenArrayPassed_ReturnReversedArray(int[] array, int[] expected)
        {
            int[] actual = Arrays.ReverseArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 7, 0, -4, 3, 5, 137, -857, 1 }, 7)]
        [TestCase(new int[] { -134, -57, -836, -57, -173, 17482 }, 3)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 4 }, 0)]
        [TestCase(new int[] { -1, 0, 1 }, 2)]
        public void CountOddElementsOfTheArray_WhenArrayPassed_ReturnTheNumberOfOddElementsInTheArray(int[] array, int expected)
        {
            int actual = Arrays.CountOddElementsOfTheArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 7, 0, -4, 3, 5, 137, -857, 1 }, new int[] { 5, 137, -857, 1, 3, 3, 7, 0, -4 })]
        [TestCase(new int[] { -134, -57, -836, -57, -173, 17482 }, new int[] { -57, -173, 17482, -134, -57, -836 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 4 }, new int[] { 0, 0, 0, 4, 0, 0, 0, 0 })]
        [TestCase(new int[] { -1, 0, 1 }, new int[] { 1, 0, -1 })]
        public void ChangePlacesOfArrayHalves_WhenArrayPassed_ReturnArrayWithChangedPlacesOfArrayHalves(int[] array, int[] expected)
        {
            int[] actual = Arrays.ChangePlacesOfArrayHalves(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 7, 0, -4, 3, 5, 137, -857, 1 }, new int[] { -857, -4, 0, 1, 3, 3, 5, 7, 137 })]
        [TestCase(new int[] { -134, -57, -836, -57, -173, 17482 }, new int[] { -836, -173, -134, -57, -57, 17482 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 4 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 4 })]
        [TestCase(new int[] { -1, 0, 1 }, new int[] { -1, 0, 1 })]
        public void SortArrayAscending_WhenArrayPassed_ReturnArraySortedInAscendingOrder(int[] array, int[] expected)
        {
            int[] actual = Arrays.SortArrayAscending(array);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 3, 7, 0, -4, 3, 5, 137, -857, 1 }, new int[] { 137, 7, 5, 3, 3, 1, 0, -4, -857 })]
        [TestCase(new int[] { -134, -57, -836, -57, -173, 17482 }, new int[] { 17482, -57, -57, -134, -173, -836 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 4 }, new int[] { 4, 0, 0, 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { -1, 0, 1 }, new int[] { 1, 0, -1 })]
        public void SortArrayDescending_WhenArrayPassed_ReturnArraySortedInDescendingOrder(int[] array, int[] expected)
        {
            int[] actual = Arrays.SortArrayDescending(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
