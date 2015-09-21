using UnityEngine;
using System.Collections;

public class GAMEOVER : MonoBehaviour {

	public GameObject Restart;
		public GameObject GO;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerExit (Collider otherObject){
		Debug.Log ("trigger");
		Instantiate (Restart, transform.position, transform.rotation);
		Instantiate (GO, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
