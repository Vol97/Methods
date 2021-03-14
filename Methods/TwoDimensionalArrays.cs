using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public static class TwoDimensionalArrays
    {
        public static int FindMinimumValueInATwoDimensionalArray(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            if (array.Length == 0)
            {
                throw new ArgumentException("Array has no elements");
            }

            int minValue = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (minValue > array[i, j])
                    {
                        minValue = array[i, j];
                    }
                }
            }

            return minValue;
        }
        public static int FindMaximumValueInATwoDimensionalArray(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Null array.");
            }
            if (array.Length == 0)
            {
                throw new ArgumentException("Array has no elements");
            }

            int maxValue = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxValue < array[i, j])
                    {
                        maxValue = array[i, j];
                    }
                }
            }

            return maxValue;
        }
        public static int[] FindMinimumValueIndexInATwoDimensionalArray(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Null array.");
            }
            if (array.Length == 0)
            {
                throw new ArgumentException("Array has no elements");
            }

            int[] minValueIndex = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[minValueIndex[0], minValueIndex[1]] > array[i, j])
                    {
                        minValueIndex[0] = i;
                        minValueIndex[1] = j;
                    }
                }
            }

            return minValueIndex;
        }
        public static int[] FindMaximumValueIndexInATwoDimensionalArray(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Null array.");
            }
            if (array.Length == 0)
            {
                throw new ArgumentException("Array has no elements");
            }

            int[] maxValueIndex = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[maxValueIndex[0], maxValueIndex[1]] < array[i, j])
                    {
                        maxValueIndex[0] = i;
                        maxValueIndex[1] = j;
                    }
                }
            }

            return maxValueIndex;
        }
        public static int CountNumbersInAMatrixThatAreBiggerThanAllTheirNeighbours(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Null array.");
            }
            if (array.Length == 0)
            {
                throw new ArgumentException("Array has no elements");
            }

            int absoluteMaxNumberCount = 0;
            int trueCount;
            int neighbourCount;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    neighbourCount = 0;
                    trueCount = 0;
                    for (int k = -1; k <= 1; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            if (i + k >= 0
                                && i + k < array.GetLength(0)
                                && j + l >= 0
                                && j + l < array.GetLength(1)
                                && array[i, j] > array[i + k, j + l]
                                && !(k == 0 && l == 0))
                            {
                                ++trueCount;
                                ++neighbourCount;
                            }
                            if (i + k >= 0
                                && i + k < array.GetLength(0)
                                && j + l >= 0
                                && j + l < array.GetLength(1)
                                && array[i, j] <= array[i + k, j + l]
                                && !(k == 0 && l == 0))
                            {
                                ++neighbourCount;
                            }
                        }
                    }
                    if (trueCount == neighbourCount)
                    {
                        ++absoluteMaxNumberCount;
                    }
                }
            }

            return absoluteMaxNumberCount;
        }
        public static int[,] TransposeAMatrix(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Null array.");
            }
            if (array.Length == 0)
            {
                throw new ArgumentException("Array has no elements");
            }

            int[,] resArray = new int[array.GetLength(1), array.GetLength(0)];

            for (int i = 0; i < resArray.GetLength(0); i++)
            {
                for (int j = 0; j < resArray.GetLength(1); j++)
                {
                    resArray[i, j] = array[j, i];
                }
            }

            return resArray;
        }
    }
}
