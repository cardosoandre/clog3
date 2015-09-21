using UnityEngine;
using System.Collections;

public class ByeShip : MonoBehaviour {
	
	public GameObject Boom;
	public GameObject Snd;

	void OnTriggerEnter ( Collider otherObject) {
		Debug.Log ("trigger");
		Destroy (gameObject);
		Instantiate (Boom, transform.position, transform.rotation);
		Instantiate (Snd, transform.position, transform.rotation);
	}
}
