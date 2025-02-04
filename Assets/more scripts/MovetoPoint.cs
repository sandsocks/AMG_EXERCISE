using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovetoPoint : MonoBehaviour
{
    public enum MovementType
    {
        Linear,
        EaseIn,
        EaseOut
    }

    public Transform target;
    [SerializeField] private float duration = 3f;

    private float totalTime;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        this.transform.position = Vector3.Lerp(startPos, target.position, Test.NormalizeTime(totalTime, duration));
        this.transform.position = ;
/*
        var normalizedTime = Test.NormalizeTime(totalTime, duration);
        switch (movementType)
            {
                case MovementType.Linear:
                    this.transform.position = Vector3.Lerp(startPos, target.position, normalizedTime);
                    break;

                case MovementType.EaseIn:
                    this.transform.position = Vector3.Lerp(startPos, target.position, Test.EaseIn(normalizedTime));
                    break;

                case MovementType.EaseOut:
                    this.transform.position = Vector3.Lerp(startPos, target.position, Test.EaseOut(normalizedTime));
                    break;
*/
        }

        
    }
}
