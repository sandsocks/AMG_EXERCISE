using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class VectorsTest : MonoBehaviour
{
public GameObject Player, Target;
    public float PlayerTestMagnitude, PlayerTargetMagnitude, TestTargetMagnitude;
    public GameObject Test;

    void Start()
    {
        Vector2 playerPosition = Player.transform.position;
        Vector2 targetPosition = Target.transform.position;
        Vector2 testPosition = Test.transform.position;

        bool isInBetween = IsPointInBetween (playerPosition, targetPosition, testPosition);

        if (isInBetween)
        {
            Debug.Log("Is in between");
        }

        else
        {
            Debug.Log("Is not in between");
        }
    }

    bool IsPointInBetween (Vector2 player, Vector2 target, Vector2 test)
    {
        Vector2 PlayerTargetDirection = target - player;
        Vector2 PlayerTestDirection = test - player;
        Vector2 TestTargetDirection = test - target;


        PlayerTargetMagnitude = Mathf.Sqrt((PlayerTargetDirection.x * PlayerTargetDirection.x) + (PlayerTargetDirection.y * PlayerTargetDirection.y));
        PlayerTestMagnitude = Mathf.Sqrt((PlayerTestDirection.x * PlayerTestDirection.x) + (PlayerTestDirection.y * PlayerTestDirection.y));
        TestTargetMagnitude = Mathf.Sqrt((TestTargetDirection.x * TestTargetDirection.x) + (TestTargetDirection.y * TestTargetDirection.y));

        if (PlayerTestMagnitude + TestTargetMagnitude == PlayerTargetMagnitude)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}




