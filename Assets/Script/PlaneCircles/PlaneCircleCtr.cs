using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlaneCircleCtr : MonoBehaviour
{

    public PlayableDirector playableDirector;
    public List<MeshRenderer> meshRenderers = new List<MeshRenderer>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopCircle() {
        playableDirector.Stop();
        foreach (var item in meshRenderers)
        {
            item.enabled = false;
        }
        
    }

    public void PlayCircle() {
        foreach (var item in meshRenderers)
        {
            item.enabled = true;
        }
        playableDirector.Play();
    }
}
