using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Dropdown dd;

	public void OnDropDownSelected()
	{
	//	Debug.Log (dd.options[dd.value];
	//		if dd.value = 1 .........
		GameObject mddgo = GameObject.Find ("Dropdown");
		Dropdown dd = mddgo.GetComponent<Dropdown> ();
		Debug.Log (dd.value);

		if (dd.value == 2) {
			UnityEditor.EditorApplication.isPlaying = false;
		}

	}
}
