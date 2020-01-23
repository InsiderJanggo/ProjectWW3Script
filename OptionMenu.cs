using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour {
	public Button OptionBtn;
	public GameObject Optionpanel;
	public GameObject mainMenu;
	public Button saveBtn;
	// Use this for initialization
	void Start () {
		OptionBtn.onClick.AddListener(beforeClicking);
		saveBtn.onClick.AddListener (afterClicking);
	}
	public void beforeClicking()
	{
		Optionpanel.gameObject.active = true;
	}
	public void afterClicking()
	{
		Optionpanel.gameObject.active = false;
	}
}
