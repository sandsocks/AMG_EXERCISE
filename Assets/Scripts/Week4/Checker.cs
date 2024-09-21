using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    [SerializeField] public GameObject target, point;
    [SerializeField] public float length;
    [SerializeField] public Vector2 direction, normalized;
    void Start()
    {
        
    }


    void Update()
    {
        direction = target.transform.position - point.transform.position;
        length = Mathf.Sqrt((direction.x * direction.x) + (direction.y * direction.y));
        normalized = direction / length;
    }

    public float DotPrtoduct(Vector3 A, Vector3 B)
    {
        var xValue = A.x * B.x;
        var yValue = A.y * B.y;
        var zValue = A.z * B.z;
        return xValue + yValue + zValue;
    }
}
