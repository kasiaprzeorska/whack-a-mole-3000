using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misz : MonoBehaviour {
	
	public float speed = 4f;
	public Transform target;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Mouse Y")<0)
		{
			transform.Translate(0, 0, (Input.GetAxis("Mouse Y")) * Time.deltaTime * speed * 3);

		}
		else
		{
			transform.Translate(0, 0, (Input.GetAxis("Mouse Y")) * Time.deltaTime * speed * 3);

		}
		if(Input.GetAxis("Mouse X")<0)
		{
			transform.Translate((Input.GetAxis("Mouse X")) * Time.deltaTime * speed * 3, 0, 0 );

		}
		else
		{
			transform.Translate((Input.GetAxis("Mouse X")) * Time.deltaTime * speed * 3, 0, 0);

		}

		
		
	}
}

