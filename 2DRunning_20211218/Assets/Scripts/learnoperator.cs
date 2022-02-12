using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class learnoperator : MonoBehaviour
{
    public float a = 1;
    public float b = 3;
    public float c = 5;
    public float d = 4;

    private void Start()
    {
        #region 運算子:數學
        // 加 +
        print("增加:" + (a + b));
        // 減 -
        print("減少:" + (a - b));
        // 乘 *
        print(":乘" + (a * b));
        // 除 /
        print("除:" + (a / b));
        // 餘 %
        print("餘:" + (a % b));
        #endregion

        #region 運算子:比較
        // 大於   >
        print("大於:" + (c > d));
        // 小於   <
        print("小於:" + (c < d));
        // 大於等於  >=
        print("大於等於:" + (c >= d));
        // 小於等於   <=
        print("小於等於:" + (c <= d));
        // 等於   ==
        print("等於:" + (c == d));
        // 不等於  !=
        print("不等於:" + (c != d));


        #endregion

        #region 運算子:邏輯
        //並且 &&(shift+7)
        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);
        //或者 ||(shift|)
        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);

        //顛倒 !
        print(!true);
        print(!false);

        #endregion


    }

}