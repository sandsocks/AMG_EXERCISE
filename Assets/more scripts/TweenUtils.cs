using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public static float EaseIn(float t)
    {
        return t * t;
    }
    public static float EaseOut(float t)
    {
        return 1 - (1 - t) * (1 - t);
    }

    public static float NormalizeTime(float t, float maxTime)
    {
        return Mathf.Clamp01 (t/maxTime);
    }
}
