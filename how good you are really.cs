using System;
using System.Linq;
using NUnit.Framework;

public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        if (ClassPoints.Average() < YourPoints)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}