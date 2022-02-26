using UnityEngine;

/// <summary>
/// 自行練習API 練習內容 老師給的目標
/// 搜尋unity API ...  得知用法 https://docs.unity3d.com/ScriptReference/Application.OpenURL.html
/// 內容網址 https://paper.dropbox.com/doc/C--Bcqr9juySGNcnwbnJU5KkZVIAg-rEKAPFSoMNq3GOxEx45vY
/// </summary>
public class APIstatictraining : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        #region//取得
        //顯示所有攝影機的數量
        print("所有攝影機數量" + Camera.allCamerasCount); 
        
        //顯示2D的重力大小
        print("2D 的重力大小" + Physics2D.gravity);
        
        //顯示圓周率
        print("圓周率" + Mathf.PI);
        #endregion

        #region//存放
        //將重力設定為-20
        Physics2D.gravity = new Vector2(0, -20);
        
        //時間速度為0.5倍
        Time.timeScale = 0.5f;

        #endregion

        #region//使用
        //去9.999小數點
        float number9999 = Mathf.Ceil(9.999f);   //Ceil = 無條件進位  //Round 四捨五入 //Floor 無條件捨去
        print("去9.999小數點=" + number9999);
       
        //計算a , b點的距離
        Vector3 a = Vector3.one;
        Vector3 b = Vector3.one * 22;
        float dis = Vector3.Distance(a, b);
        print("a點和b點的距離" + dis);

        //是否按下任意鍵
        print("是否按下任意鍵" + Input.anyKey);

        //開啟網站
        Application.OpenURL("https://unity.com/");

        #endregion
    }
    void Update()
    {
        #region//取得
        //是否按下空白鍵
        print("是否按下任意鍵" + Input.anyKey);

        //顯示經過的時間
        //print("經過時間" + Time.time);

        #endregion

        #region //存放
        #endregion   //也有存放類型

        #region//使用
        //是否按下空白鍵
        print("是否按下空白鍵" + Input.GetKeyDown(KeyCode.Space));
        #endregion
    }
}
