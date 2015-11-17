using UnityEngine;
using System.Collections;

public class ZombieWalking : MonoBehaviour {

	private Vector3 playerPosition;
	private Vector3 zombiePosition;
	// Use this for initialization
	void Start () 
	{
		zombiePosition = GetComponent<Rigidbody>().position;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		playerPosition=PlayerController.playerRigidBody.position;
		if (zombiePosition.x - playerPosition.x > 0) {
			zombiePosition.x -= .01f;
		} else if (zombiePosition.x - playerPosition.x < 0) {
			zombiePosition.x += .01f;
		}
		if (zombiePosition.z - playerPosition.z > 0) {
			zombiePosition.z -= .01f;
		} else if (zombiePosition.z - playerPosition.z < 0) {
			zombiePosition.z += .01f;
		}
		GetComponent<Rigidbody> ().position = zombiePosition;
	}
}
