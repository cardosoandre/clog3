using UnityEngine;
using System.Collections;

public class Killzone : MonoBehaviour {

	public GameObject Boom;
	public float speed; 
	public float speed2; 
	public GameObject Spawners;
	public GameObject Reset;
	public GameObject Warning;
	public GameObject Snd;

	void OnTriggerExit ( Collider otherObject) {
		Debug.Log ("trigger");
		Destroy (gameObject);
		Instantiate (Boom, transform.position, transform.rotation);
		Instantiate (Snd, transform.position, transform.rotation);
		}

	// Update is called once per frame
	void Update () {
		transform.Rotate(Time.deltaTime, speed, speed2);

	}
}