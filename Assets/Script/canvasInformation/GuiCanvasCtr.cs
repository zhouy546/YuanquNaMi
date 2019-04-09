using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiCanvasCtr : MonoBehaviour
{
    public List<CanvasInforNode> canvasInforNodes = new List<CanvasInforNode>();
    // Start is called before the first frame update
    void Start()
    {
        EventCenter.AddListener<CanvasInforNode>(EventDefine.ShouGuiCanvas, ShowOne);

        EventCenter.AddListener(EventDefine.ShowMainScene, HideAll);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowOne(CanvasInforNode _canvasInforNode) {
     //   Debug.Log("run");
        foreach (var item in canvasInforNodes)
        {
         //   Debug.Log(_canvasInforNode.Equals(item));
            if (_canvasInforNode.Equals(item)) {
                item.show();
            }
            else
            {
                item.hide();
            }
        }

        EventCenter.Broadcast(EventDefine.HideMainScene);
    }

    public void HideAll()
    {
        foreach (CanvasInforNode item in canvasInforNodes)
        {
            item.hide();
        }
    }
}
