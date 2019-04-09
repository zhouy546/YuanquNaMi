using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ImageLoopType {
    top,mid,bottom,Null,
}

[System.Serializable]
public  class MoveConstant
{
    public Transform top;
    public Color topOpacity;

    public Transform mid;
    public Color midOpacity;

    public Transform bottom;
    public Color bottomOpacity;

    public Transform _null;
    public Color _nullOpacity;
}

public class PicLoopCtr : MonoBehaviour
{
    public List<PicNode> picNodes = new List<PicNode>();

    public MoveConstant moveConstant;

    // Start is called before the first frame update
    void Start()
    {
        SetupPicLinkedList();
        SetupLoopType();
        StartCoroutine(UpdateImageLoop());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Show() {
        StopAllCoroutines();

        StartCoroutine(UpdateImageLoop());
    }


    public IEnumerator UpdateImageLoop() {
        yield return new WaitForSeconds(4f);
        moveNext();
       
        StartCoroutine(UpdateImageLoop());
    }

    private void moveNext() {
        //ImageLoopType _imageLoopType = picNodes[0].getLoopType();


        PicNode tempPicNode = picNodes[0].Clone();

        for (int i = 0; i < picNodes.Count-1; i++)
        {
            picNodes[i].setLoopType(picNodes[i].next.getLoopType(), moveConstant);
        }
        picNodes[picNodes.Count - 1].setLoopType(tempPicNode.getLoopType(), moveConstant);
    }


    public void SetupLoopType() {
        for (int i = 0; i < picNodes.Count; i++)
        {
            picNodes[i].setLoopType(TypeConvert(i), moveConstant);
        }
    }


    public void SetupPicLinkedList() {
        for (int i = 0; i < picNodes.Count; i++)
        {


            if (picNodes.Count == 1)
            {
                picNodes[0].pervious = picNodes[0];
                picNodes[0].next = picNodes[0];
            }
            else if (picNodes.Count == 2)
            {
                picNodes[0].pervious = picNodes[1];
                picNodes[0].next = picNodes[1];
                picNodes[1].pervious = picNodes[0];
                picNodes[1].next = picNodes[0];
            }
            else {

                if (i == 0)
                {
                    picNodes[i].pervious = picNodes[picNodes.Count - 1];
                    picNodes[i].next = picNodes[i+1];
                }
                else if (i == picNodes.Count - 1)
                {
                    picNodes[i].pervious = picNodes[i-1];
                    picNodes[i].next = picNodes[0];

                }
                else {
                    picNodes[i].pervious = picNodes[i - 1];
                    picNodes[i].next = picNodes[i + 1];
                }
            }
        }
    }

    public ImageLoopType TypeConvert(int index) {
        if (index == 0)
        {
            return ImageLoopType.top;
        }
        else if (index == 1)
        {
            return ImageLoopType.mid;
        }
        else if (index == 2)
        {
            return ImageLoopType.bottom;
        }
        else {
            return ImageLoopType.Null;
        }
    }
}
