using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

	public void LoadScene(int level)
	{
		SceneManager.LoadScene ("spc1_a1");
	}
	public void QuitGame()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit ();
		#endif
	}
	public void LoadOptionPanel(int level)
	{
		SceneManager.LoadScene("OptionPanel");
		Debug.Log ("Loading...");
	}
	public void ReturnToMainMenu(int level)
	{
		SceneManager.LoadScene ("mainmenu");
	}
	public void loadMp(int level)
	{
		SceneManager.LoadScene ("mp_mainmenu");
		Debug.Log ("Loading...");
	}
}
