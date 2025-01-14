using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
     float XAngleValue;
    float YAngleValue;

    [SerializeField] private float xscalarValue = 4;
    [SerializeField] private float yscalarValue = 4;
    [SerializeField] private float xorbitValue = 4;
    [SerializeField] private float yorbitValue = 4;
    [SerializeField] private float orbitRadius = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        XAngleValue = Time.deltaTime * xscalarValue;
        YAngleValue = Time.deltaTime * yscalarValue;
        this.transform.position = new Vector3 (Mathf.Cos(XAngleValue), this.transform.position.y, Mathf.Sin(YAngleValue));
    }
}
