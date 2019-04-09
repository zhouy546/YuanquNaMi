using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
[RequireComponent(typeof (PlayableDirector))]
public class CanvasInforNode : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public PlayableAsset[] playableAssets = new PlayableAsset[2];
    public int ID;
    public int udp;

    private bool isEnable=true;

    public PicLoopCtr loopCtr;
    // Start is called before the first frame update
    void Start()
    {
        hide();
        ValueSheet.updPair.Add(udp.ToString(), this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void show() {
        if (!isEnable) {
            isEnable = true;
            playableDirector.Play(playableAssets[0]);
            //if (loopCtr != null) {
            //    loopCtr.Show();
            //}
        }     
    }

    public void hide() {
        if (isEnable)
        {
            isEnable = false;
            playableDirector.Play(playableAssets[1]);
        }
    }
}
