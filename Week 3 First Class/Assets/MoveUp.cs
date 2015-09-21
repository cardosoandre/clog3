using UnityEngine;
using System.Collections;

public class MoveUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//move up through scene
		transform.position = transform.position + Vector3.up * 3f * Time.deltaTime;
	
	}
}
