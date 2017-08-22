using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow))        
            anim.SetBool("move_Down", true);

        if (Input.GetKeyUp(KeyCode.DownArrow))
            anim.SetBool("move_Down", false);

        if (Input.GetKeyDown(KeyCode.UpArrow))
            anim.SetBool("move_Up", true);

        if (Input.GetKeyUp(KeyCode.UpArrow))
            anim.SetBool("move_Up", false);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            anim.SetBool("move_Left", true);

        if (Input.GetKeyUp(KeyCode.LeftArrow))
            anim.SetBool("move_Left", false);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            anim.SetBool("move_Right", true);

        if (Input.GetKeyUp(KeyCode.RightArrow))
            anim.SetBool("move_Right", false);
    }
}
