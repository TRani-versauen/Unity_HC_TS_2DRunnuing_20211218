using UnityEngine;

/// <summary>
/// 學習判斷式
/// 1.if
/// 2.switch
/// </summary>
public class learncondition : MonoBehaviour
{
    public bool haskey = true;

    private int health = 0;

    public string gear;


    //列舉enum (下拉式選單)
    //1.定義列舉
    public enum Mode
    {
        easy, normal, hard
    }
    //2.實作列舉
    public Mode mode;

    private void Start()
    {
        //if語法 : if (布林值) {程式區塊、演算法、陳述式}
        //快速完成: if + tab * 2

        //布林值 等於true 會執行{}裡的指令
        //布林值 等於false 不會執行{}裡的指令
        #region if判斷式
        if (true)
        {
            print("我是判斷式");
        }

        //布林值 等於true 會執行if{}裡的指令
        //布林值 等於false 會執行else{}裡的指令
        if (haskey)
        {
            print("可以開門");
        }
        else
        {
            print("無法開門");
        }
        #endregion
        #region switch判斷式
        //switch 語法
        //switch(判斷的資料)
        //{
        //     case 值1:
        //       程式內容;
        //       程式內容;
        //       break;
        //     case 值2:
        //       程式內容;
        //       程式內容;
        //       break;
        //     default:
        //       程式內容;
        //       程式內容;
        //       break;
        //}
        switch (gear)
        {
            case "能量加成":
                print("能量回復強化");
                break;
            case "體力加成":
                print("傷害增加");
                print("體力強化");
                break;
            case "視野加成":
                print("視野增加");
                break;
        }
        #endregion
        #region switch + enum 判斷式
        // switch + enum
        switch (mode)
        {
            case Mode.easy:
                print("簡單模式");
                break;
            case Mode.normal:
                print("簡單模式");
                break;
            case Mode.hard:
                print("簡單模式");
                break;
        }
        #endregion
    }
    private void Update()
    {
        if (health > 50)
        {
            print("正常移動速度");
        }
        else if (health > 10 && health < 50)
        {
            print("虛弱移動速度");
        }
        else if (health <= 10 && health >= 0)
        {
            print("瀕死移動速度");
        }
    }
}