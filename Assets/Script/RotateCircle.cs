using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rotate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotate() {;
        LeanTween.rotateAroundLocal(this.gameObject, Vector3.up, 360, 5f).setOnComplete(Rotate).setEase(LeanTweenType.easeInOutQuad);
    }
}
