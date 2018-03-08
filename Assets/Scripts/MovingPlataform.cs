using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlataform : MonoBehaviour {

    private float speed;
    public float directionSpeed = 9.0f;
    float origX;
    public float distance = 10.0f;
    private bool grounded;
    private int move;

    void Start()
    {
        origX = transform.position.x;
        speed = -directionSpeed;
    }


    void Update()
    {
        if (origX - transform.position.x > distance)
        {
            speed = directionSpeed; //flip direction
        }
        else if (origX - transform.position.x < -distance)
        {
            speed = -directionSpeed; //flip direction
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }

    

}
