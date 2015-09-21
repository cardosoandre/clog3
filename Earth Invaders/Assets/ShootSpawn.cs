using UnityEngine;
using System.Collections;

public class ShootSpawn : MonoBehaviour {

	public GameObject PurpleBlast;
	public float speed = -10;
	public AudioSource audiohehe;

	// Use this for initialization
	void Start () {

		AudioSource audio = GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")){
			Instantiate(PurpleBlast, transform.position, transform.rotation);
			GetComponent<AudioSource>().Play();
		}
	}
}
