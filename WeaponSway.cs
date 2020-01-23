using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSway : MonoBehaviour {
	public float Amount;
	public float maxAmount;
	public float smoothAmount;

	private Vector3 initPosition;
	// Use this for initialization
	void Start () {
		initPosition = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		float movementX = -Input.GetAxis ("Mouse X") * Amount;
		float movementY = -Input.GetAxis ("Mouse Y") * Amount;
		movementX = Mathf.Clamp (movementX, -maxAmount, maxAmount);
		movementY = Mathf.Clamp (movementY, -maxAmount, maxAmount);

		Vector3 finalPosition = new Vector3 (movementX, movementY, 0);
		transform.localPosition = Vector3.Lerp (transform.localPosition, finalPosition + initPosition, Time.deltaTime * smoothAmount);
	}
}
