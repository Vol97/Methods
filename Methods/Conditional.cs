using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public static class Conditional
    {
        public static double ComparingAandBIfAisBiggerAddThemIfAequalsBMultiplyElseAMinusB(double a, double b)
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

        public static double[] AscendingNumberSorting(double a, double b, double c)
        {
            double[] res = null;

            if (a > b && a > c)
            {
                if (b > c)
                {
                    res = new double[] { c, b, a };
                }
                else
                {
                    res = new double[] { b, c, a };
                }
            }
            if (b > a && b > c)
            {
                if (a > c)
                {
                    res = new double[] { c, a, b };
                }
                else
                {
                    res = new double[] { a, c, b };
                }
            }
            if (c > a && c > b)
            {
                if (a > b)
                {
                    res = new double[] { b, a, c }; ;
                }
                else
                {
                    res = new double[] { a, b, c };
                }
            }

            return res;
        }

        public static double[] SolvingQuadraticEquation(double a, double b, double c)
        {
            double[] res = null;
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

            }

            return res;
        }
    }
}
