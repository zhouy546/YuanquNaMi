using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SceneCtr : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public PlayableAsset[] playableAssets = new PlayableAsset[2];
    private bool isEnable = true;
    // Start is called before the first frame update
    void Start()
    {
        EventCenter.AddListener(EventDefine.HideMainScene, HideDefault);
        EventCenter.AddListener(EventDefine.ShowMainScene, ShowDefault);
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            HideDefault();
        }
        else if (Input.GetKeyDown(KeyCode.Q)) {
            ShowDefault();
        }
    }

    public void ShowDefault() {
        if (!isEnable) {
            isEnable = true;
            playableDirector.Play(playableAssets[0]);


        }
    }

    public void HideDefault() {
        if (isEnable) {
            isEnable = false;
            playableDirector.Play(playableAssets[1]);

        }
    }


}
