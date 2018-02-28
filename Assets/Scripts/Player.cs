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
    private float jumpForce = 3000f;
    private bool isJumping = false;


    void Start () {
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
        animatorPlayer = GetComponent<Animator>();
	}
	
	
	private void FixedUpdate () {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        animatorPlayer.SetInteger("x", (int)direction.x);
        animatorPlayer.SetInteger("y", (int)direction.y);


        rigidbodyPlayer.velocity = direction * speed;
        if (Input.GetKeyDown(jumpKey) && !isJumping)
        {
            animatorPlayer.SetBool("jump", true);
            isJumping = true;
            rigidbodyPlayer.AddForce(Vector2.up * jumpForce * Time.deltaTime);

        }
        direction.Normalize();

    }
}
