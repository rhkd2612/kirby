using UnityEngine;
using System.Collections;

public class KirbyAnimatior : MonoBehaviour {

    Animator animator;
    private bool walking = false;
    private bool jumping = false;

    public KirbyMove groundCrash;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(!jumping)
                walking = true;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!jumping)
                walking = true;
        }
        else
            walking = false;

        if (groundCrash.ground)
            jumping = false;
        else if (!groundCrash.ground)
            jumping = true;

        animator.SetBool("move", walking);

        animator.SetBool("jump", jumping);
    }
}
