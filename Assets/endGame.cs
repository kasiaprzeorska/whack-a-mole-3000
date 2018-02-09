using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour {

    bool koniecGry = false;
    public static endGame Instance;
    Image obrazek;
    Text koniecTekst;
    Text wynik;
    Text najlepszyWynik;

    private void Awake()
    {
        Instance = this;

    }

    // Use this for initialization
    void Start () {
        obrazek = GameObject.Find("koniecGry").GetComponent<Image>();
        koniecTekst = GameObject.Find("msg").GetComponent<Text>();
        wynik = GameObject.Find("wynik").GetComponent<Text>();
        najlepszyWynik = GameObject.Find("najlepszyWynik").GetComponent<Text>();
        obrazek.enabled = false;
        koniecTekst.enabled = false;
        wynik.enabled = false;
        najlepszyWynik.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (koniecGry)
        {
            GameObject.Find("Timer").GetComponent<pause>().enabled = false;
            GameObject.FindWithTag("ruszacz").GetComponent<MoveWithMouse>().enabled = false;
            wynik.text = "Wynik - " + PlayerPrefs.GetInt("wynikGry");
            obrazek.enabled = true;
            koniecTekst.enabled = true;
            wynik.enabled = true;
            if (PlayerPrefs.GetInt("wynikGry") > PlayerPrefs.GetInt("topScore"))
            {
                najlepszyWynik.enabled = true;
                PlayerPrefs.SetInt("topScore", PlayerPrefs.GetInt("wynikGry"));
            }
            Time.timeScale = 0;
            if (Input.GetKeyDown("escape"))
            {
                SceneManager.LoadScene("menu");
            }
        }
    }

    public void setKoniecGry(bool toSet)
    {
        koniecGry = toSet;
    }
}
