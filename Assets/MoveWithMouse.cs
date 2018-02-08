using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMouse : MonoBehaviour {

	public Vector3 targetPos;
	public Vector3 farawayPoint;
	Plane plane;
	
	void Start () {
		targetPos = transform.position;
		plane = new Plane(Vector3.up,transform.position);
		farawayPoint = new Vector3 (targetPos.x, targetPos.y, targetPos.z + 10);
	}

	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		float point = 0f;

		if(plane.Raycast(ray, out point))
			targetPos = ray.GetPoint(point);
		
		transform.position = new Vector3(targetPos.x, targetPos.y, targetPos.z);
		transform.LookAt (farawayPoint);
	
	}
}
