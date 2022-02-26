using System.Diagnostics;
using UnityEngine;

/// <summary>
/// 學習非靜態API
/// 非靜態 nonstatic
/// 實體物件，存在遊戲場景內的物件
/// 1.取得靜態語法
/// 2.存放靜態語法
/// 3.使用靜態語法
/// </summary>
public class learnAPInonstatic : MonoBehaviour
{
    public Transform traCar1;
    public GameObject goCar;

    private void Start()
    {
        #region 教學
        //靜態與非靜態的最大差異
        //1.非靜態需要一個實體物件存在
        //2.定義 一個欄位
        //3.儲存該使體物件
        //實體物件:
        //1.遊戲物件Game Object :在 Hierarchy 內的白色線框圖示物件
        //2.預置物 Prefab :在 Hierarchy 內的藍色廂型圖示物件   
        //3.元件 Component:1 與 2 屬性面板上可折疊的

        //非屬性語法
        //1.取得 get
        //欄位名稱.非靜態屬性名稱 
        print("箱型車的位置" + traCar1.position);

        //2.存放 set
        //欄位名稱.非靜態屬性名稱 指定 值;
        transform.position = new Vector3(-5, 3, 1);

        //靜態方法語法
        //3. 使用
        //欄位使用. 非靜態屬性名稱(對應的引數);
        goCar.SetActive(false);
        #endregion
    }
}

