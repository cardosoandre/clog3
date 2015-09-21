using UnityEngine;
using System.Collections;

public class AlreadyStart : MonoBehaviour {

	public float initTime = 300f;
	public ParticleSystem partEmitter;
	public float speed; 
	public float speed2; 

	// Use this for initialization
	void Start () {

			partEmitter.Simulate(initTime);
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Time.deltaTime, speed, speed2);
	
	}
}
