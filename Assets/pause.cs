using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour {

    private bool isPaused;
    private GameObject rzecz;
    private Image image;
    private Text text;

	// Use this for initialization
	void Start () {
        isPaused = false;
        rzecz = GameObject.FindWithTag("ruszacz");
        image = GameObject.Find("pauseOverlay").GetComponent<Image>();
        text = GameObject.Find("pauseOverlay").GetComponentInChildren<Text>();
        image.enabled = false;
        text.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("escape"))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            Time.timeScale = 0;
            rzecz.GetComponent<MoveWithMouse>().enabled = false;
            image.enabled = true;
            text.enabled = true;
        } else
        {
            Time.timeScale = 1;
            rzecz.GetComponent<MoveWithMouse>().enabled = true;
            image.enabled = false;
            text.enabled = false;
        }
	}
}
