using UnityEngine;
using System.Collections;

public class ExplodeKey : MonoBehaviour {
	public GameObject Boom;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			Destroy (gameObject);
			Instantiate (Boom, transform.position, transform.rotation);
		}
	
	}
}
