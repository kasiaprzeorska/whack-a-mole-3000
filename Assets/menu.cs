using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {
	public Canvas Menu;
	public Button StartB;
	public Button Exit;
	public Canvas ToExit;
	public Button Yes;
	public Button No;



	// Use this for initialization
	void Start () {
		Menu = GetComponent<Canvas> ();
		ToExit = GetComponent<Canvas> ();
		StartB = GetComponent<Button>();
		Exit = GetComponent<Button> ();
		Yes = GetComponent<Button> ();
		No = GetComponent<Button> ();
		Menu.enabled = true;
		ToExit.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}



}

