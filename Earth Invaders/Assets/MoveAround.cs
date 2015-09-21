using UnityEngine;
using System.Collections;

public class MoveAround : MonoBehaviour {

	public float speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (-Vector3.forward * speed * Input.GetAxis ("Horizontal") * Time.deltaTime);

	}
}
