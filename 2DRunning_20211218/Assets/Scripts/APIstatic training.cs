using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 自行練習API 練習內容 老師給的目標
/// 內容網址 https://paper.dropbox.com/doc/C--Bcqr9juySGNcnwbnJU5KkZVIAg-rEKAPFSoMNq3GOxEx45vY
/// </summary>
public class APIstatictraining : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        #region//取得
        print("所有攝影機數量" + Camera.allCamerasCount);
        print("2D 的重力大小" + Physics2D.gravity);
        print("圓周率" + Mathf.PI);
        #endregion

        #region//存放
        Physics2D.gravity = new Vector2(0, -20);
        Time.timeScale = 0.5f;

        #endregion

        #region//使用
        float number9999 = Mathf.Ceil(9.999f);   //Ceil = 無條件進位  //Round 四捨五入 //Floor 無條件捨去
        print("去9.999小數點=" + number9999);
        Vector3 a = Vector3.one;
        Vector3 b = Vector3.one * 22;
        float dis = Vector3.Distance(a , b);
        print("a點和b點的距離" + dis);
        #endregion


        void Update()
    {
            #region//取得
            print("是否按下任意鍵" + Input.anyKey);
            print("經過時間" + Time.time);
            #endregion
            
            #region//存放
            #endregion
            
            #region//使用
            #endregion
        }
    }
