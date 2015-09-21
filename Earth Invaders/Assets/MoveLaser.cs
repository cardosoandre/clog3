using UnityEngine;
using System.Collections;

public class MoveLaser : MonoBehaviour {

	public float speed = 5;

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.name == "Earth" || other.gameObject.tag == "Enemy") {
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		transform.position = transform.position + -transform.up * speed * Time.deltaTime ;
	
	}
}
