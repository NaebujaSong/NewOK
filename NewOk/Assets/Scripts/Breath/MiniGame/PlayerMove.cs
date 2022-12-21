using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float speed = 500;
    private float horizontal;
    public bool isDie = false;

	// Use this for initialization
	void Start () {
        _rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        horizontal = Input.GetAxis("Horizontal");
        
        if(!isDie)
        PlayerMoving();
    }

    private void PlayerMoving()
    {
        _rigidbody.velocity = new Vector2(horizontal * speed, _rigidbody.velocity.y);        
    }
    
    private void ScreenChk()
    {
        Vector3 worlpos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (worlpos.x < 0.05f) worlpos.x = 0.05f;
        if (worlpos.x > 0.95f) worlpos.x = 0.95f;
        this.transform.position = Camera.main.ViewportToWorldPoint(worlpos);
    }
}
