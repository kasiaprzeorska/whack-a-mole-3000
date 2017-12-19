using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class punktacja : MonoBehaviour {
	public static int punkty;
	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		punkty = 0;
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Punkty: " + punkty;
	}
}
