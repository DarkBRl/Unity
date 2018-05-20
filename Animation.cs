using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Animation : MonoBehaviour {

    Animator anim;
	void Start ()
    {
        anim = GetComponent<Animator>();	
	}
	
	
	void FixedUpdate ()
    {
        float move0 = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", move0);
        float move1 = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", move1);

    }
}
