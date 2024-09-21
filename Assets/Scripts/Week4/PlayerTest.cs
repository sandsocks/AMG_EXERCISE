using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    [SerializeField] private Transform toPoint;
    //[SerializeField] private AccessTest testAccess;

    void Start()
    {
        Debug.DrawLine(transform.position, toPoint.transform.position, Color.white, 5f);
    }
    void Update()
    {
        
    }
}
