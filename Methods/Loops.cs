﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public static class Loops
    {
        public static double RaiseAToPowerB (double a, double b)
        {
            double raisedToPower = 1;

            for (int i = 0; i < b; i++)
            {
                raisedToPower *= a;
            }

            return raisedToPower;
        }

        public static int[] ReturnArrayOfNumbersFrom1to1000ThatCanBeDividedByN(int n)
        {
            int counterForArraySize = 0;

            for (int i = n; i <= 1000; i += n)
            {
                ++counterForArraySize;
            }

            int[] resArray = new int[counterForArraySize];
            int counterForArrayIndex = 0;

            for (int i = n; i <= 1000; i += n)
            {
                resArray[counterForArrayIndex] = i;
                ++counterForArrayIndex;
            }

            return resArray;
        }

        public static int[] ReturnArrayOfNumbersThatWhenRaisedToPower2AreLessThanN(int n)
        {
            int counterForArraySize = 0;

            for (int i = 1; i * i < n; i++)
            {
                ++counterForArraySize;
            }

            int[] resArray = new int[counterForArraySize];
            int counterForArrayIndex = 0;

            for (int i = 1; i * i < n; i++)
            {
                resArray[counterForArrayIndex] = i;
                ++counterForArrayIndex;
            }
            return resArray;
        }

        public static int ReturnTheBiggestDividerOfN(int n)
        {
            int res = 0;

            for (int i = n - 1; i != 0; i--)
            {
                if (n % i == 0)
                {
                    res = i;
                    break;
                }
            }

            return res;
        }
        public static int ReturnSumOfNumbersInRangeFromAtoBThatCanBeDividedBy7WithoutRemainder(int a, int b)
        {
            if (b < a)
            {
                int temp;
                temp = a;
                a = b;
                b = temp;
            }

            int sum = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
        public static int ReturnNumberNFromFibonacciSequence(int n)
        {
            int fibonacciN1 = 1;
            int fibonacciN2 = 1;
            int fibonacciN = 0;

            if (n < 0)
            {
                throw new ArgumentException();
            }
            else if (n > 0 && n <= 2)
            {
                fibonacciN = fibonacciN1;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    fibonacciN = fibonacciN1 + fibonacciN2;
                    fibonacciN1 = fibonacciN2;
                    fibonacciN2 = fibonacciN;
                }
            }

            return fibonacciN;
        }
        public static int FindGreatestCommonDivisorOfAandB(int a, int b)
        {
            int divisor = 1;

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    divisor = b;
                    a = a % b;
                }
                else
                {
                    divisor = a;
                    b = b % a;
                }
            }

            return divisor;
        }
        public static int FindCubicRootOfN(int n)
        {
            int start = 1;
            int end = n;

            while (true)
            {
                int mid = (start + end) / 2;

                if (Math.Pow(mid, 3) > n)
                {
                    end = mid;
                }
                else if (Math.Pow(mid, 3) < n)
                {
                    start = mid;
                }
                else
                {
                    return mid; ;
                }
            }
        }
        public static int FindOddNumbersInN(int n)
        {
            int number;
            int oddNumbers = 0;

            while (n % 10 != 0)
            {
                number = n % 10;

                if (number % 2 != 0)
                {
                    ++oddNumbers;
                }
                n /= 10;
            }

            return oddNumbers;
        }
        public static int ReturnMirrorNumber(int n)
        {
            string mirrorNumber = string.Empty;

            while (n % 10 != 0)
            {
                mirrorNumber += n % 10;
                n /= 10;
            }

            return Convert.ToInt32(mirrorNumber);
        }
        public static int[] RerurnNumbersInRangeFrom1toNWhereSumOfEvenNumbersIsBiggerThanSumOfOdd(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int sumOfEven = 0;
                int sumOfOdd = 0;

                for (int number = i; number > 0; number /= 10)
                {
                    if ((number % 10) % 2 == 0)
                    {
                        sumOfEven += number % 10;
                    }
                    else
                    {
                        sumOfOdd += number % 10;
                    }
                }

                if (sumOfEven > sumOfOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}