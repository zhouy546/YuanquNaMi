using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomCircleImage : ictr
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void hide()
    {
        base.hide();
    }

    public override void show()
    {
        animator.SetTrigger("Play");

    }
}
