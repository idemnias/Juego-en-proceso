using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float speed = 5f;
    private Vector2 direction = Vector2.zero;
    private Rigidbody2D rigidbodyPlayer;
    private Animator animatorPlayer;
    [SerializeField]
    private KeyCode jumpKey = KeyCode.Space;
    [SerializeField]
    private Vector2 jumpForce;

    void Start () {
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
        animatorPlayer = GetComponent<Animator>();
	}
	
	
	private void FixedUpdate () {
        direction.x = Input.GetAxisRaw("Horizontal");

        animatorPlayer.SetInteger("x", (int)direction.x);
        direction.Normalize();

        rigidbodyPlayer.velocity = direction * speed;
        if (Input.GetKeyDown(jumpKey))
        {
            rigidbodyPlayer.AddForce(new Vector2(0, 10));

        }


    }
}
