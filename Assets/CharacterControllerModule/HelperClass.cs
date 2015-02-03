using UnityEngine;
using System.Collections;

public static class HelperClass
{
    public static bool IsCloseToZero(float value, float precision = 0.01f)
    {
        if (precision <= 0.0f)
        {
            precision = 0.01f;
        }
        return (value < precision && value > -precision);
    }
}
