using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float speed=0.1f;
	private Rigidbody rb;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal*speed, 0.0f, moveVertical*speed);
		rb.position = rb.position + movement;
	}
}
