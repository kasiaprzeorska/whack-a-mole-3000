using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    Image fillImg;
    float timeAmount = 90;
    float time;
    public int amaunt;

	// Use this for initialization
	void Start () {
        fillImg = GetComponent<Image>();
        fillImg.color = Color.green;
        time = timeAmount;
	}
	
	// Update is called once per frame
	void Update () {
		if(time > 0)
        {
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timeAmount;
        }
        if (fillImg.fillAmount < 0.66 & fillImg.fillAmount > 0.34)
        {
            fillImg.color = Color.yellow;
        } else if (fillImg.fillAmount < 0.33)
        {
            fillImg.color = Color.red;
        }
        if (time <= 0)
        {
            PlayerPrefs.SetInt("wynik", punktacja.punkty);
            amaunt = PlayerPrefs.GetInt("wynik");
        }
	}
}
