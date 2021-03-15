using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public static class Conditional
    {
        public static double ComparingABIfAisBiggerAddABIfAequalsBMultiplyElseAMinusB(double a, double b)
        {
            double res;

            if (a > b)
            {
                res = a + b;
            }
            else if (a == b)
            {
                res = a * b;
            }
            else
            {
                res = a - b;
            }

            return res;
        }

        public static string FindingPlaceOnACoordinatePlane(double x, double y)
        {
            string res = string.Empty;

            if (x * y > 0)
            {
                if (x > 0)
                {
                    res = "1st quadrant";
                }
                else
                {
                    res = "3rd quadrant";
                }
            }
            if (x * y < 0)
            {
                if (x > 0)
                {
                    res = "4th quadrant";
                }
                else
                {
                    res = "2nd quadrant";
                }
            }
            if (x * y == 0)
            {
                if (x == 0 && y == 0)
                {
                    res = "The coordinate plane origin";
                }
                else if (x != 0)
                {
                    res = "X axis";
                }
                else
                {
                    res = "Y axis";
                }
            }

            return res;
        }

        public static void AscendingNumberSorting(ref double a, ref double b, ref double c)
        {
            if (a > b && a > c)
            {
                if (b > c)
                {
                    Variables.SwapVariables(ref a, ref c);
                }
                else
                {
                    Variables.SwapVariables(ref a, ref c);
                    Variables.SwapVariables(ref b, ref c);
                }
            }
            if (b > a && b > c)
            {
                if (a > c)
                {
                    Variables.SwapVariables(ref b, ref c);
                    Variables.SwapVariables(ref a, ref b);
                }
                else
                {
                    Variables.SwapVariables(ref c, ref b);
                }
            }
            if (c > a && c > b)
            {
                if (a > b)
                {
                    Variables.SwapVariables(ref a, ref b);
                }
            }
        }

        public static double[] SolvingQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("a = 0, so 2*a = 0. Can't divide by zero");
            }

            double[] res;
            double x;
            double x2;
            double d = b * b - (4 * a * c);

            if (d >= 0)
            {
                if (d > 0)
                {
                    x = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);

                    res = new double[] { x, x2 };
                }
                else
                {
                    x = -b / (2 * a);

                    res = new double[] { x };
                }
            }
            else
            {
                res = new double[0];
            }

            return res;
        }

        public static string TurnTwoDigitNumberIntoText(int number)
        {
            if (number < 10 && number > -10 && number < -99 || number > 99)
            {
                throw new ArgumentException("Not a two-digit number");
            }

            string numberText = null;

            if (number < 0)
            {
                number = Math.Abs(number);
                numberText = "минус ";
            }

            int ten = number / 10;
            int digits = number % 10;
            string tenText = null;
            string digitsText = null;

            if (number >= 10 && number <= 19)
            {
                switch (number)
                {
                    case (10):
                        numberText += "десять";
                        break;
                    case (11):
                        numberText += "одинадцать";
                        break;
                    case (12):
                        numberText += "двенадцать";
                        break;
                    case (13):
                        numberText += "тринадцать";
                        break;
                    case (14):
                        numberText += "четырнадцать";
                        break;
                    case (15):
                        numberText += "пятнадцать";
                        break;
                    case (16):
                        numberText += "шестнадцать";
                        break;
                    case (17):
                        numberText += "семнадцать";
                        break;
                    case (18):
                        numberText += "восемнадцать";
                        break;
                    case (19):
                        numberText += "девятнадцать";
                        break;
                }
            }
            else
            {
                switch (ten)
                {
                    case (2):
                        tenText = "двадцать";
                        break;
                    case (3):
                        tenText = "тридцать";
                        break;
                    case (4):
                        tenText = "сорок";
                        break;
                    case (5):
                        tenText = "пятьдесят";
                        break;
                    case (6):
                        tenText = "шестьдесят";
                        break;
                    case (7):
                        tenText = "семьдесят";
                        break;
                    case (8):
                        tenText = "восемьдесят";
                        break;
                    case (9):
                        tenText = "девяносто";
                        break;
                }
                switch (digits)
                {
                    case (1):
                        digitsText = " один";
                        break;
                    case (2):
                        digitsText = " два";
                        break;
                    case (3):
                        digitsText = " три";
                        break;
                    case (4):
                        digitsText = " четыре";
                        break;
                    case (5):
                        digitsText = " пять";
                        break;
                    case (6):
                        digitsText = " шесть";
                        break;
                    case (7):
                        digitsText = " семь";
                        break;
                    case (8):
                        digitsText = " восемь";
                        break;
                    case (9):
                        digitsText = " девять";
                        break;
                }
            }

            numberText += $"{tenText}{digitsText}";

            return numberText;
        }
    }
}
