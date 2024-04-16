using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extention
{
    private const string format0N0 = "{0:N0}";
    private const string format0N1 = "{0:N1}";
    private const string format0N2 = "{0:N2}";
    private const string format0N3 = "{0:N3}";

    public static string ToString_Func(this float value, int pointNumber = 0)
    {
        if (0 < pointNumber)
        {
            if (pointNumber == 1)
            {
                return string.Format(format0N1, value);
            }
            else if (pointNumber == 2)
            {
                return string.Format(format0N2, value);
            }
            else if (pointNumber == 3)
            {
                return string.Format(format0N3, value);
            }
            else
            {
                return value.ToString();
            }
        }
        else
        {
            return string.Format(format0N0, value);
        }
    }
}
