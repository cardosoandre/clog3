using UnityEngine;
using System.Collections;

public class SpawnPill : MonoBehaviour {

	public GameObject Goomba;
	private bool canShoot;
	private float time = .5f;

	// Use this for initialization
	void Start () {
		canShoot = true;
	}

	// remember to test InvokeRepeating
	// remember to test InvokeCancel

	void spawnAPill() {
		Instantiate (Goomba, transform.position, transform.rotation);
		canShoot = false;
		Invoke ("turnOnShooter", time);
	}

	void turnOnShooter () {
		canShoot = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (canShoot == true) {
			spawnAPill ();
			}
		}
	
	}
}
