using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float speed = 3;
    private float horizontal;

	// Use this for initialization
	void Start () {
        _rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        horizontal = Input.GetAxis("Horizontal");
        PlayerMoving();
    }

    private void PlayerMoving()
    {
        _rigidbody.velocity = new Vector2(horizontal * speed, _rigidbody.velocity.y);        
    }
}
