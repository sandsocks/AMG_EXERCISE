using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuhUh : MonoBehaviour
{
    public GameObject Player, Target, Test; 
    public Vector2 direction, normalized, pointInBetween;
    public float distance;
    private float playerPosition, targetPosition, testPosition;

    public bool isInBetween;
    
    void Update()
    {
       direction = Test.transform.position - Player.transform.position;

        Vector2 playerPosition = Player.transform.position;
        Vector2 targetPosition = Target.transform.position;
        Vector2 testPosition = transform.position;

        distance = Mathf.Sqrt((direction.x * direction.x) + (direction.y * direction.y));
        normalized = direction / distance;

        //isInBetween = IsPointInBetween (playerPosition, targetPosition, testPosition);
    }
}


