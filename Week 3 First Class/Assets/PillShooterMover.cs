using UnityEngine;
using System.Collections;

public class PillShooterMover : MonoBehaviour {

	public float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + new Vector3 ( Input.GetAxis ("Horizontal") * speed * Time.deltaTime, 0, 0);
	
	}
}
