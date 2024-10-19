using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private GameObject target;
    [SerializeField] private Transform startPos, endPos;

    [Range(0f, 1f)]
    [SerializeField] private float time , travelTime = 10f;
    private float Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target.transform.position = Vector2.Lerp(startPos.position, endPos.position, Timer/travelTime);
        Timer += Time.deltaTime;
        text.text = Timer.ToString();
    }
}
