using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mlotkowy : MonoBehaviour {
	public float distance = 10f;
	public bool useInitialCameraDistance = false;
	private float actualDistance;

	void Start(){
		if (useInitialCameraDistance) {
			Vector3 toObjectVector = transform.position - Camera.main.transform.position;
			Vector3 linearDistanceVector = Vector3.Project (toObjectVector, Camera.main.transform.forward);
			actualDistance = toObjectVector.magnitude;
		}
		else {
			actualDistance = distance;
		}
	}

	void Update(){
		Vector3 mousePosition = Input.mousePosition;
		mousePosition.z = actualDistance;
		transform.position = Camera.main.ScreenToWorldPoint (mousePosition);
		
	}
}
