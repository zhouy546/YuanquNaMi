using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PicNode : MonoBehaviour
{
    public ImageLoopType loopType = ImageLoopType.Null;
    
    public PicNode next;
    public PicNode pervious;

    public Image m_image;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public PicNode Clone() {
        return this.MemberwiseClone() as PicNode;
    }

    public ImageLoopType getLoopType()
    {
        return loopType;
    }

    public void  setLoopType(ImageLoopType _looptype,MoveConstant _moveConstant) {
        Debug.Log("running");
        loopType = _looptype;
        switch (_looptype)
        {
            case ImageLoopType.top:
                goTop(_moveConstant);
                break;
            case ImageLoopType.mid:
                goMid(_moveConstant);
                break;
            case ImageLoopType.bottom:
                goBottom(_moveConstant);
                break;
            case ImageLoopType.Null:
                goNull(_moveConstant);
                break;
            default:
                break;
        }
    }

    public void goTop(MoveConstant _moveConstant) {
        LeanTween.move(this.gameObject, _moveConstant.top.position,0.2f);
        setAlpha(_moveConstant.topOpacity.a);
    }

    public void goMid(MoveConstant _moveConstant) {
        LeanTween.move(this.gameObject, _moveConstant.mid.position, 0.2f);
        setAlpha(_moveConstant.midOpacity.a);
        
    }

    public void goBottom(MoveConstant _moveConstant) {
        LeanTween.move(this.gameObject, _moveConstant.bottom.position, 0.2f);
        setAlpha(_moveConstant.bottomOpacity.a);
    }

    public void goNull(MoveConstant _moveConstant) {
        LeanTween.move(this.gameObject, _moveConstant._null.position, 0.2f);
        setAlpha(_moveConstant._nullOpacity.a);
     
    }


    private void setAlpha(float alpha) {
        LeanTween.value(this.gameObject, m_image.color.a, alpha, 0.2f).setOnUpdate((float val) => { m_image.color = new Color(m_image.color.r, m_image.color.g, m_image.color.b, val); });
    }
}
