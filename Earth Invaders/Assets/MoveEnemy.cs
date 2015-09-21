using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour {

	public float speed = 10f;
	public GameObject Explosion;
	public GameObject Sound;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 10);

	
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.tag == "Laser") {
			Destroy (gameObject);
			Instantiate (Explosion, transform.position, transform.rotation);
			Instantiate (Sound, transform.position, transform.rotation);

		}
	}
	
	// Update is called once per frame
	void Update () {
	transform.position = transform.position + transform.up * speed * Time.deltaTime ;
	
	}
}
