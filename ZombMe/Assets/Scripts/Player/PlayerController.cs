using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float speed=0.1f;
	static public Rigidbody playerRigidBody;
	// Use this for initialization
	void Start () 
	{
		playerRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal*speed, 0.0f, moveVertical*speed);
		playerRigidBody.position = playerRigidBody.position + movement;
	}
}
