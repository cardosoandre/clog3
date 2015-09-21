using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().AddForce (Random.insideUnitSphere * 500);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
