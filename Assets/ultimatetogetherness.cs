using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ultimatetogetherness : MonoBehaviour {

	public bool onGround;
	private Rigidbody rbody;
	private bool canGetPoint;
	public Texture[] texturescat;
	public Texture[] texturesmole;
	int i;
	public static int mnoznik = 1;
	public static int liczmnoznik;
	public AudioClip[] auclip;
	private AudioSource source;



	// Use this for initialization
	void Start () {
		onGround = true;
		canGetPoint = false;
		rbody = GetComponent<Rigidbody> ();
		source = GetComponent<AudioSource> ();
		i = Random.Range(0,2);
		if (i == 0)
			GetComponent<Renderer>().material.mainTexture = texturescat [0];
		else
			GetComponent<Renderer>().material.mainTexture = texturesmole [0];
		Invoke ("Skok", Random.Range (3, 16));
        mnoznik = 1;
        liczmnoznik = 0;
	}

	// Update is called once per frame
	void Update () {		
	}

	void OnCollisionEnter(Collision col){
		if (i == 0) {
			if (col.gameObject.CompareTag ("Ground")) {
				onGround = true;
				GetComponent<Renderer> ().material.mainTexture = texturescat [0];
				i = Random.Range(0,3);
				if (i ==0)
					GetComponent<Renderer> ().material.mainTexture = texturescat [0];
				else
					GetComponent<Renderer> ().material.mainTexture = texturesmole [0];
				Invoke ("Skok", Random.Range (8, 15));
			}
			if (col.gameObject.CompareTag ("mlotek")) {
                rbody.velocity = new Vector3(0, -30, 0);
                if (!onGround & canGetPoint) {
					punktacja.punkty -= 1;
					source.PlayOneShot (auclip [1]);
					GetComponent<Renderer> ().material.mainTexture = texturescat [1];
					if (mnoznik > 1)
						mnoznik = mnoznik / 2;
					else
						mnoznik = 1;
					liczmnoznik = 0;
					canGetPoint = false;

				}
			}
		}
		else {
			
				if (col.gameObject.CompareTag ("Ground")) {
					onGround = true;
					GetComponent<Renderer> ().material.mainTexture = texturesmole [0];
					i = Random.Range(0,3);
					if (i ==0)
						GetComponent<Renderer> ().material.mainTexture = texturescat [0];
					else
						GetComponent<Renderer> ().material.mainTexture = texturesmole [0];
					Invoke ("Skok", Random.Range (8, 15));

				}
				if (col.gameObject.CompareTag ("mlotek")) {
                rbody.velocity = new Vector3(0, -30, 0);
                if (!onGround & canGetPoint) {
						GetComponent<Renderer> ().material.mainTexture = texturesmole [1];
						punktacja.punkty += 1 * mnoznik;
						canGetPoint = false;
						liczmnoznik += 1;
						if (liczmnoznik > 5) {
							mnoznik = mnoznik * 2;
							liczmnoznik = 0;
							source.PlayOneShot (auclip [0]);
						}

					}		

				}
			}
		}

		void Skok(){
		if (onGround) {
			rbody.velocity = new Vector3 (0f, 8f, 0f);
			onGround = false;
			canGetPoint = true;
		}


	}

}