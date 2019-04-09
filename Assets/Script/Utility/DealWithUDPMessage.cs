
//*********************❤*********************
// 
// 文件名（File Name）：	DealWithUDPMessage.cs
// 
// 作者（Author）：			LoveNeon
// 
// 创建时间（CreateTime）：	Don't Care
// 
// 说明（Description）：	接受到消息之后会传给我，然后我进行处理
// 
//*********************❤*********************

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Linq;

public class DealWithUDPMessage : MonoBehaviour {


    public static DealWithUDPMessage instance;
    // public GameObject wellMesh;
    private string dataTest;

    private int CountDownTime = 180;
    private int CurrenCountDownTime;

    /// <summary>
    /// 消息处理
    /// </summary>
    /// <param name="_data"></param>
    public void MessageManage(string _data)
    {
        if (_data != "")
        {


            dataTest = _data;

           Debug.Log(dataTest);

            // Debug.Log(ValueSheet.updPair[dataTest].ID);
            if (dataTest == "2042")
            {
                EventCenter.Broadcast(EventDefine.ShowMainScene);
            }

            if (ValueSheet.updPair.ContainsKey(dataTest)) {
                EventCenter.Broadcast<CanvasInforNode>(EventDefine.ShouGuiCanvas, ValueSheet.updPair[dataTest]);
                CurrenCountDownTime = CountDownTime;
            }

       



        }

    }



    private void Awake()
    {
        CurrenCountDownTime = CountDownTime;
    }

    public IEnumerator Initialization() {
        if (instance == null)
        {
            instance = this;
        }
        yield return new  WaitForSeconds(0.01f);
    }

    public void Start()
    {
        StartCoroutine(CountDown());
    }


    private void Update()
    {


        //Debug.Log("数据：" + dataTest);  
    }

    public IEnumerator CountDown()
    {
        yield return new WaitForSeconds(1);
        CurrenCountDownTime--;
        if (CurrenCountDownTime == 0)
        {
            EventCenter.Broadcast(EventDefine.ShowMainScene);
            CurrenCountDownTime = CountDownTime;
        }

        //Debug.Log(CurrenCountDownTime);
        StartCoroutine(CountDown());
    }


}
