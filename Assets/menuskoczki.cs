using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuskoczki : MonoBehaviour {
	public bool onGround;
	private Rigidbody rbody;
	public Texture texturescat;
	public Texture texturesmole;
	int i;
	// Use this for initialization
	void Start () {
		onGround = true;
		rbody = GetComponent<Rigidbody> ();
		i = Random.Range(0,2);
		if (i == 0)
			GetComponent<Renderer>().material.mainTexture = texturescat;
		else
			GetComponent<Renderer>().material.mainTexture = texturesmole;
		Invoke ("Skok", Random.Range (3, 16));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter (Collision col)
	{
		
		if (col.gameObject.CompareTag ("Ground")) {
			onGround = true;
			i = Random.Range (0, 3);
			if (i == 0)
				GetComponent<Renderer> ().material.mainTexture = texturescat;
			else
				GetComponent<Renderer> ().material.mainTexture = texturesmole;
			Invoke ("Skok", Random.Range (8, 15));
		}
	}
	void Skok ()
	{
		if (onGround) {
			rbody.velocity = new Vector3 (0f, 8f, 0f);
			onGround = false;
		}
	}
}
