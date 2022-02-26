using UnityEngine;

/// <summary>
/// 自行練習API 練習內容 老師給的目標
/// 搜尋unity API ...  得知用法 https://docs.unity3d.com/ScriptReference/Application.OpenURL.html
/// 內容網址 https://paper.dropbox.com/doc/C--Bcrdn9p5SYb9TaBIe25z5bexAg-EsPpCQXko0Vt7P1tmH9so
/// </summary>
public class APInonstatictraining : MonoBehaviour
{
    public Camera cam;
    public SpriteRenderer spr;
    public Transform banana;
    public Rigidbody2D apple;

    void Start()
    {
        //顯示攝影機景深
        print("主攝影機景深" + cam.depth);
        //取得奇異果的顏色
        print("奇異果的顏色" + spr.color);
        //攝影機的背景顏色 (隨機顏色)
        cam.backgroundColor = Random.ColorHSV();
        spr.flipY = true;

    }

    void Update()
    {
        //讓香蕉旋轉
        banana.Rotate(0, 0, 5);
        //讓蘋果以加速度的方式向上移動
        apple.AddForce(new Vector2(0,10));
    }
}
