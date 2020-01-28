using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {
	public Camera playerCam;
	public Camera tankCam;
	public KeyCode enterVehicle = KeyCode.F;
	// Use this for initialization
	void Start () {
		playerCam.enabled = true;
		tankCam.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (enterVehicle)) {
			ShowTankCamera ();
		} else if(Input.GetKey(KeyCode.Escape)){
			ShowPlayerCamera ();
		}
	}

	public void ShowTankCamera() {
		playerCam.enabled = false;
		tankCam.enabled = true;
	}

	public void ShowPlayerCamera() {
		playerCam.enabled = true;
		tankCam.enabled = false;
	}
}
