using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    [SerializeField] private Transform target;
    private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            var direction = (target.position - transform.position).normalized;
            this.transform.position += direction * speed * Time.deltaTime;
        }
    }
}
