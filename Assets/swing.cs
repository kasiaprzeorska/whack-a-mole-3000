using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour {

    public Animator anim;

    void Start() {
        anim = GetComponent<Animator>();

	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.Play("swing");
        }
    }
}
