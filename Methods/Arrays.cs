using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public static class Arrays
    {
        public static int FindMinimumValueInArray(int[] array)
        {
            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }
        public static int FindMaximumValueInArray(int[] array)
        {
            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }
        public static int FindMinimumValueIndexInArray(int[] array)
        {
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[minIndex] > array[i])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }
        public static int FindMaximumValueIndexInArray(int[] array)
        {
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[maxIndex] < array[i])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
        public static int ReturnSumOfNumbersWithOddIndexes(int[] array)
        {
            int arrayOddIndexSum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                arrayOddIndexSum += array[i];
            }

            return arrayOddIndexSum;
        }
        public static int[] ReverseArray(int[] array)
        {
            int[] reverseArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[i] = array[array.Length - 1 - i];
            }

            return reverseArray;
        }
        public static int CountOddElementsOfTheArray (int[] array)
        {
            int oddNumbers = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    ++oddNumbers;
                }
            }

            return oddNumbers;
        }
        public static int[] ChangePlacesOfArrayHalves (int[] array)
        {
            int[] reverseHalvesArray = new int[array.Length];

            if (array.Length % 2 != 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    reverseHalvesArray[i] = array[array.Length / 2 + 1 + i];
                }

                int count = 0;

                for (int j = array.Length / 2 + 1; j < array.Length; j++)
                {
                    reverseHalvesArray[j] = array[count++];
                }

                reverseHalvesArray[array.Length / 2] = array[array.Length / 2];
            }
            else
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    reverseHalvesArray[i] = array[array.Length / 2 + i];
                }

                int count = 0;

                for (int j = array.Length / 2; j < array.Length; j++)
                {
                    reverseHalvesArray[j] = array[count++];
                }
            }

            return reverseHalvesArray;
        }
        public static int[] SortArrayAscending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }

                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }

            return array;
        }
        public static int[] SortArrayDescending(int[] array)
        {
            int key;
            int temp;

            for (int i = 1; i < array.Length; i++)
            {
                key = i;

                while (key > 0 && array[key] > array[key - 1])
                {
                    temp = array[key];
                    array[key] = array[key - 1];
                    array[key - 1] = temp;

                    --key;
                }
            }

            return array;
        }
    }
}
