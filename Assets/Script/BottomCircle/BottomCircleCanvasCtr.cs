using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomCircleCanvasCtr : MonoBehaviour
{
    public List<BottomCircleImage> bottomCircleImages = new List<BottomCircleImage>(); 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoopAnim());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator LoopAnim() {
        yield return new WaitForSeconds(2f);
        foreach (BottomCircleImage item in bottomCircleImages)
        {
          
            item.show();
            yield return new WaitForSeconds(0.5f);
        }
    }
}
