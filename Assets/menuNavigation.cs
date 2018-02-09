using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuNavigation : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NowaGra(){
		SceneManager.LoadScene ("gra");
	}

	public void DoHallOfFame(){
		SceneManager.LoadScene ("hopsasa");
	}



	public void KoniecGry(){
		Application.Quit ();
	}


}
