using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour {
	[Header("Variables")]
	public GameObject gun1; // Gun That Is On The Ground
	public GameObject gunInGround; // Players Gun
	public GameObject UI; // game Ui
	public KeyCode interactKey = KeyCode.F;
	// Use this for initialization
	void Start () {
		gun1.SetActive (false);
		UI.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 fwd = transform.TransformDirection (Vector3.forward); // transform the object that the player picking up goes forward
		RaycastHit hit;
		Ray ray;

		if (Physics.Raycast (transform.position, fwd, out hit)) {
			if (hit.collider.tag == "ak117")
			{
				UI.SetActive (true);
				if (Input.GetKey (interactKey)) {
					gunInGround.SetActive (false);
					gun1.SetActive (true);
				} else {
					UI.SetActive (false);
				}
			}
		}
	}
}
