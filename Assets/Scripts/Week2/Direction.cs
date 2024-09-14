using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    public GameObject Player, Enemy;
    public Vector2 direction, normalized;
    public float length;
    private float PlayerX, PlayerY, EnemyX, EnemyY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Enemy.transform.position - Player.transform.position;

        PlayerX = Player.transform.position.x;
        PlayerY = Player.transform.position.y;
        EnemyX = Enemy.transform.position.x;
        EnemyY = Enemy.transform.position.y;

        length = Mathf.Sqrt((direction.x * direction.x) + (direction.y * direction.y));
        normalized = direction / length;
    }
}
