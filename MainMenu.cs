using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
	public Button QuitMenu;
	public Button Nobtn;
	public GameObject QuitHud;
	// Use this for initialization
	void Start () {
		Button btn = QuitMenu.GetComponent<Button>();
		Button nobtn = Nobtn.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		nobtn.onClick.AddListener(AfterClicking);
	}
	public void TaskOnClick()
	{
		QuitHud.active = true;
	}
	void AfterClicking()
	{
		QuitHud.active = false;
	}
}
