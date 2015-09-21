using UnityEngine;
using System.Collections;

public class StopSpawners : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerExit (Collider otherObject){
		Debug.Log ("trigger");
		Destroy (gameObject);}
	
	// Update is called once per frame
	void Update () {
	
	}
}
