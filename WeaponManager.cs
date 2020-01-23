using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
	public GameObject primaryWeapon;
	public GameObject secondaryWeapon;
	public GameObject meleeWeapon;
	public GameObject grenade;
	// Start is called before the first frame update
	void Start()
	{
		primaryWeapon.active = false;
		secondaryWeapon.active = false;
	}

	// Update is called once per frame
	[System.Obsolete]
	void Update()
	{
		if (Input.GetKeyUp("1"))
		{
			primaryWeapon.active = true;
			secondaryWeapon.active = false;
		}

		if (Input.GetKeyUp("2"))
		{
			primaryWeapon.active = false;
			secondaryWeapon.active = true;
		}
	}
}