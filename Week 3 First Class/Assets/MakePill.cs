using UnityEngine;
using System.Collections;

public class MakePill : MonoBehaviour {

	public GameObject SpawnerTwo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey ( KeyCode.G ) ) {
		    Instantiate( SpawnerTwo, transform.position , transform.rotation );
		    }
	
	}
}
