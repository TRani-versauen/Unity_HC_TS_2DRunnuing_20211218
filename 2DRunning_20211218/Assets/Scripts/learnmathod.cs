using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

/// <summary>
/// 學習方法
/// </summary>
public class learnmathod : MonoBehaviour
{
    //方法語法
    //修飾詞 傳回資料類型 方法名稱 () {程式內容、陳述事、演算法}
    //void 無傳回 :使用此方法不會有資料回傳

    //自訂方法
    private void Start()
    {
        //呼叫自訂方法
        //自訂方法名稱()
        Test();
        ShootFire();
        ShootIce();
        //有幾個參數就要輸入幾個引數
        //有預設值的參數可以不用給引數

        Shoot("火球", 170, effect: "燃燒");
        Shoot("冰球", 80);
        Shoot("電球", 300, "雷電音效");
        int water3 = BuyWater(3);
        float TRani = BMI(70, 1.7f);
        print("TRani BMI" + TRani);





    }

    //自訂方法:不會自動執行
    //會自動執行的叫做事件
    private void Test()
    {
        print("Test");
    }


    //發射火球﹐發射冰球、發射電球
    private void ShootFire()
    {
        print("發射火球");
        print("飛行速度 100");
        print("發射音效");
    }

    private void ShootIce()
    {
        print("發射冰球");
        print("飛行速度 50");
        print("發射音效");
    }

    //維護性與擴充性
    //參數語法:參數1類型 參數1名稱, 參數2類型 參數2名稱
    private void Shoot(string type, int speed, string sound = "預設音效", string effect = "爆炸")
    {
        print("<color=yellow>發射" + type + "</color>");
        print("<color=yellow>飛行速度" + speed + "</color>");
        print("<color=yellow>聲音" + sound + "</color>");
        print("<color=yellow>特效" + effect + "</color>");
    }
    private int BuyWater(int count)
    {

        print("買" + count + "罐");
        print("花費" + count * 50 + "元");
        int price = count * 50;
        return price;


    }
    private float BMI(float weight, float height)
    {
        float result = weight / (height * height);
        return result;
    }

}