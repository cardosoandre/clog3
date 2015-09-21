using UnityEngine;
using System.Collections;

public class SpawnMonster1 : MonoBehaviour {

	public GameObject Enemy;                // The enemy prefab to be spawned.
	public float spawnTime;            // How long between each spawn.
	public float speed;
	// Use this for initialization
	void Start () {

		InvokeRepeating("shootAuto", spawnTime, speed);
	}

	void shootAuto() {
		Instantiate (Enemy, transform.position, transform.rotation);
	}
}
