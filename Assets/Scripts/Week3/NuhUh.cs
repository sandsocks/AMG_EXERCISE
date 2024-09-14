using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class NuhUh : MonoBehaviour
{
    
    [SerializeField] public float epsilon, infinity, negativeInfinity, PI, abs, ceil, ceilToInt, clamp, clamp01, closestPowerOfTwo, exp, floatToHalf, floor, floorToInt, gammaToLinearSpace,
    halfToFloat, inverseLerp, lerp, lerpUnclamped, linearToGammaSpace, log, log10, max, min, moveTowards, nextPowerOfTwo,
    pingPong, pow, repeat, round, roundnToInt, sign, smoothDamp, smoothStep, sqrt;
    [SerializeField] public bool approximately, isPowerOfTwo;
    [SerializeField] public Color temperature;

    float smoothTime = 0.3f;
    float yVelocity = 0.0f;

    void Start()
    {
        //Mathf.Epsilon
        epsilon = Mathf.Epsilon;

        //Mathf.Infinity
        infinity = Mathf.Infinity;

        //Mathf.NegativeInfinity
        negativeInfinity = Mathf.NegativeInfinity;

        //Mathf.PI
        PI = Mathf.PI;

        //Mathf.Abs
        abs = Mathf.Abs(30.5f);

        //Mathf.Approximately
        approximately = Mathf.Approximately(6.0f, 10.0f - 4.0f);

        //Mathf.Ceil
        ceil = Mathf.Ceil(10.5f);

        //Mathf.CeilToInt
        ceilToInt = Mathf.CeilToInt(-10.2f);

        //Mathf.Clamp
        clamp = Mathf.Clamp(0.5f, 0.2f, 1.0f);

        //Mathf.Clamp01
        clamp01 = Mathf.Clamp01(2);

        //Mathf.ClosestPowerOfTwo
        closestPowerOfTwo = Mathf.ClosestPowerOfTwo(20);

        //Mathf.CorrelatedColorTemperatureToRGB
        temperature = Mathf.CorrelatedColorTemperatureToRGB(5236);

        ///Mathf.Exp
        exp = Mathf.Exp(5);

        //Mathf.FloatToHalf
        floatToHalf = Mathf.FloatToHalf(1000);

        //Mathf.Floor
        floor = Mathf.Floor(10.7f);

        //Mathf.FloorToInt
        floorToInt = Mathf.FloorToInt(5.3f);

        //Mathf.GammaToLinearSpace
        gammaToLinearSpace = Mathf.GammaToLinearSpace(2000);

        //Mathf.HalfToFloat
        halfToFloat = Mathf.HalfToFloat(100);

        //Mathf.InverseLerp
        inverseLerp = Mathf.InverseLerp(20.0f, 40.0f, 30.0f);

        //Mathf.IsPowerOfTwo
        isPowerOfTwo = Mathf.IsPowerOfTwo(32);

        //Mathf.Lerp
        lerp = Mathf.Lerp(10f , 20f, 12f);

        //Mathf.LerpUnclamped
        lerpUnclamped = Mathf.LerpUnclamped(0.5f, 1.0f, -0.25f);

        //Mathf.LinearToGammaSpace
        lineartoGammaSpace = Mathf.LinearToGammaSpace(2000);

        //Mathf.Log
        log = Mathf.Log(6, 2);

        //Mathf.Log10
        log10 = Mathf.Log10(100);

        //Mathf.Max
        max = Mathf.Max(1.0f, 3.0f);

        //Mathf.Min
        min = Mathf.Min(1.0f, 3.0f);

        //Mathf.MoveTowards
        moveTowards = Mathf.MoveTowards(20.0f, 10.0f, 5.5f);

        //Mathf.NextPowerOfTwo
        nextPowerOfTwo = Mathf.NextPowerOfTwo(14);

        //Mathf.PingPong
        pingPong = Mathf.PingPong(4, 8);

        //Mathf.Pow

        pow = Mathf.Pow(4, 2.4f);

        //Mathf.Repeat
        repeat = Mathf.Repeat(15f, 20f);

        //Mathf.Round
        round = Mathf.Round(15.5f);

        //Mathf.RoundToInt
        roundnToInt = Mathf.RoundToInt(25.8f);

        //Mathf.Sign
        sign = Mathf.Sign(8);

        //Mathf.SmoothDamp
        smoothDamp = Mathf.SmoothDamp(20.0f, 50.0f, ref yVelocity, smoothTime);

        //Mathf.SmoothStep
        smoothStep = Mathf.SmoothStep(10.0f, 20.0f, 5.0f);

        //Mathf.Sqrt
        sqrt = Mathf.Sqrt(10 * 10 + 20 * 20);
    }
}
