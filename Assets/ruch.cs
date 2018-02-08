using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruch : MonoBehaviour {


			
	void Update()
	{Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray)) {
			Instantiate (this.gameObject, transform.position, transform.rotation);
		}
	}
	

}
