
using System;
using UnityEngine;

/// <summary>
/// 學習靜態API
/// 靜態 static
/// 非實體物件，不存在遊戲場景內的物件
/// 1.取得靜態語法
/// 2.存放靜態語法
/// 3.使用靜態語法
/// </summary>
public class learnAPIstaic : MonoBehaviour
{
    private void Start()
    {
        //1.靜態屬性語法
        //取得 Get
        //類別名稱.靜態屬性名稱
        print("圓周率" + Mathf.PI);
        print("無限大" + Mathf.Infinity);

        //2.存放 Set
        //類別名稱.靜態屬性名稱 指定 值;
        //athf.Infinity PI = 9.99999f;      //唯獨屬性不能存放
        Cursor.visible = false;             //滑鼠隱藏

        //3.使用靜態語法
        //類別名稱.靜態方法名稱(對應的引數);
        float number777 = Math.Abs(-7.77f);
        print("-7.77的絕對值=" + number777);

    }
}
    

