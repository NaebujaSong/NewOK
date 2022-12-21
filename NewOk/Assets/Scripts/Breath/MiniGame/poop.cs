using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poop : MonoBehaviour {

    [SerializeField]
    private Animator animator;

    private Rigidbody2D rigidbody;
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Ground")
        {
            gameObject.SetActive(false);
            //Destroy(this.gameObject);
            GameManager.Instance.Score();
            //animator.SetTrigger("poop");
        }

        if (trigger.gameObject.tag == "Player")
        {
            trigger.gameObject.GetComponent<PlayerMove>().isDie = true;
            gameObject.SetActive(false);
            //Destroy(this.gameObject);
            GameManager.Instance.GameOver();
            //animator.SetTrigger("poop");
        }
    }
}
