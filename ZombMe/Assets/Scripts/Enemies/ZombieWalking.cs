using UnityEngine;
using System.Collections;

public class ZombieWalking : MonoBehaviour {
	
	private Vector3 playerPosition;
	private Rigidbody zombieRB;
	private Vector3 zombiePosition;
	private float speed = .05f;
	private float velocityX;
	private float velocityY;
	// Use this for initialization
	void Start () 
	{
		zombieRB = GetComponent<Rigidbody>();
		zombiePosition = zombieRB.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		playerPosition=PlayerController.playerRigidBody.position;
		zombieRB.transform.LookAt (playerPosition);

		if (zombiePosition.x - playerPosition.x > 0) {
			zombiePosition.x -= speed;
			velocityX=-.01f;
			//zombieRB.AddForce (zombieRB.transform.forward * 1f);
			print ("Left");
		} else if (zombiePosition.x - playerPosition.x < 0) {
			zombiePosition.x += speed;
			velocityX=.01f;
			//zombieRB. (zombieRB.transform.forward * -1f);
			print ("Right");
		}
		if (zombiePosition.z - playerPosition.z > 0) {
			zombiePosition.z -= speed;
			velocityY=-.01f;
			//zombieRB.AddForce (zombieRB.transform.right * .1f);
			print ("Bot");
		} else if (zombiePosition.z - playerPosition.z < 0) {
			zombiePosition.z += speed;
			velocityY=.01f;
			//zombieRB.AddForce (zombieRB.transform.right * -.1f);
			print ("Top");
		}
		//Vector3 addedVelocity = new Vector3 (velocityX, 0.0f, velocityY);
		//zombieRB.transform.Translate((Vector3)(zombiePosition-playerPosition));
		//zombieRB.AddRelativeForce (zombieRB.transform.forward * 1f);
		zombieRB.transform.position = zombiePosition;

		//  GetComponent<Rigidbody> ().position = zombiePosition;
	}
}
