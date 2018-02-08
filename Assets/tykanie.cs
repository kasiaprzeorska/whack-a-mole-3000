using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tykanie : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Główna rzecz"){
			transform.Translate(1,0,1);
		}
	}
					
	
}
