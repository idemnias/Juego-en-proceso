using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinglePatrol : MonoBehaviour {

    public GameObject startPoint;
    public GameObject endPoint;

    public float Speed =6;

    private bool isGoingRight;
	// Use this for initialization
	void Start () {
        if (!isGoingRight)
        {
            transform.position = startPoint.transform.position;
        }
        else
        {
            transform.position = endPoint.transform.position;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (isGoingRight)
        {
            transform.position = Vector3.MoveTowards(transform.position,endPoint.transform.position, Speed * Time.deltaTime);
            if(transform.position == endPoint.transform.position)
            isGoingRight = false;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if(!isGoingRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPoint.transform.position, Speed * Time.deltaTime);
            if (transform.position == startPoint.transform.position)
                isGoingRight = true;
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(startPoint.transform.position, endPoint.transform.position);
    }
}
