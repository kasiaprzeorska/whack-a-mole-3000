using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skokitwokot : MonoBehaviour {

	public bool onGround;
	private Rigidbody rbody;
	private bool canGetPoint;

	// Use this for initialization
	void Start () {
		onGround = true;
		canGetPoint = false;
		rbody = GetComponent<Rigidbody> ();
		Invoke ("Skok", Random.Range (3, 8));
			}

	// Update is called once per frame
	void Update () {		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.CompareTag ("Ground")) {
			onGround = true;
			GetComponent<Renderer> ().material.color = Color.green;
			Invoke ("Skok", Random.Range (3, 8));
		}
		if (col.gameObject.CompareTag ("mlotek")) {
			if (!onGround & canGetPoint) {
				punktacja.punkty -= 1;
				if (skokitwo.mnoznik > 1)
					skokitwo.mnoznik = skokitwo.mnoznik / 2;
				else
					skokitwo.mnoznik = 1;
				skokitwo.liczmnoznik = 0;
				canGetPoint = false;
				GetComponent<Renderer> ().material.color = Color.red;
			}		
		}
	}

	void Skok(){
		if (onGround) {
			rbody.velocity = new Vector3 (0f, 7f, 0f);
			onGround = false;
			canGetPoint = true;
			}
	}

}