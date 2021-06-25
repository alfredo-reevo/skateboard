using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{

    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            anim.Play("Skateboarding-Move");
        }
        if (Input.GetKeyUp("w"))
        {
            anim.Play("Skateboarding-idle");
        }
    }
}
