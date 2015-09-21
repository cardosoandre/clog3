using UnityEngine;
using System.Collections;

public class AlwaysSpin : MonoBehaviour {

	public float speed = 50;
	public int dir;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate ((Vector3.forward * dir) * speed * Time.deltaTime);

	}
}
