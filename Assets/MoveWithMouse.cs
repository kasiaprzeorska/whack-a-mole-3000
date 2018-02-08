using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMouse : MonoBehaviour {

	public Vector3 targetPos;
	public Vector3 farawayPoint;
	public Plane plane;
	
	void Start () {
		targetPos = transform.position;
		plane = new Plane(Vector3.up, transform.position);
		farawayPoint = new Vector3 (targetPos.x, targetPos.y, targetPos.z + 5);
	}

	// Update is called once per frame
	void Update () {
        farawayPoint = new Vector3(farawayPoint.x, farawayPoint.y, targetPos.z + 5);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		float point = 0f;

        if (plane.Raycast(ray, out point))
        {
            targetPos = ray.GetPoint(point);
            if (targetPos.z > 14)
            {
                targetPos.z = 14;
            }
            if (targetPos.x < 5)
            {
                targetPos.x = 5;
            }
            if (targetPos.x > 15)
            {
                targetPos.x = 15;
            }
        }
		
		transform.position = new Vector3(targetPos.x, targetPos.y, targetPos.z);
		transform.LookAt (farawayPoint);
	
	}
}
