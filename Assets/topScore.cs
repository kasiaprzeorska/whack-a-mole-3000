using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topScore : MonoBehaviour {

    Text wynik;
    string bestScore;

    // Use this for initialization
    void Start () {
        wynik = GameObject.Find("TopScore").GetComponent<Text>();
        bestScore= PlayerPrefs.GetInt("topScore", 0).ToString();
    }
	
	// Update is called once per frame
	void Update () {
        wynik.text = "Najlepszy wynik - " + bestScore;
    }
}
