using UnityEngine;
using System.Collections;

public class KillOtherObject : MonoBehaviour {

	void OnTriggerExit( Collider otherObject) {
		Debug.Log ("trigger");
		Destroy (otherObject.gameObject);
	}
}
