using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareRoot : MonoBehaviour
{
    [SerializeField] private float value, squareRoot;

    // Update is called once per frame
    void Update()
    {
        squareRoot = Mathf.Sqrt(value);
    }
}
