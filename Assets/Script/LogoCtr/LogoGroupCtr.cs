using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoGroupCtr : MonoBehaviour
{
    public List<LogoCtr> logoCtrs = new List<LogoCtr>();
    // Start is called before the first frame update
    void Start()
    {
        EventCenter.AddListener(EventDefine.ShowMainScene, ShowAll);
        EventCenter.AddListener(EventDefine.HideMainScene, HideAll);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideAll() {
        foreach (var item in logoCtrs)
        {
            item.Hide();
        }
    }

    public void ShowAll() {
        foreach (var item in logoCtrs)
        {
            item.Show();
        }
    }
}
