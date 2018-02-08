using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour {

    public float smooth = 1F;
	public bool macha = false;
	Quaternion startRotation;
	Quaternion newRotation;

	void Start() {
		startRotation = gameObject.transform.localRotation;
	}

    void Update() {
		if (Input.GetKeyDown(KeyCode.Mouse0) && !macha) {
			macha = true;
		}
		if (macha) {
			doSwing();
		}

		if (Input.GetKeyDown(KeyCode.A)) {
			Debug.Log(gameObject.transform.localRotation.x);
		}
    }

	void doSwing()
	{   

		transform.localRotation = Quaternion.Slerp(transform.rotation, new Quaternion(0f, startRotation.y, startRotation.z, 1f), 0.5f);

		if (gameObject.transform.rotation.x > -0.01 && 
			gameObject.transform.rotation.x < 0.01) {
			stopDoing();
		}
	}

	void stopDoing() {
		gameObject.transform.localRotation = startRotation;
		macha = false;
	}
}
