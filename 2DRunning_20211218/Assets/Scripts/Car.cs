using UnityEngine;  // 引用 Unity 引擎空間，讓我們可以使用裡面的 API (倉庫)

// 類別 類別名稱 (必須與檔案名稱完全一致，大小寫也是)
public class Car : MonoBehaviour
{
    // 此類別的內容

    #region 欄位 Field
    // ※ 欄位語法
    // 資料類型 欄位名稱 結尾
    // ※ 四大常用資料類型
    // 整　數 int
    // 浮點數 float
    // 字　串 string
    // 布林值 bool
    int cc;
    float weight;
    string brand;
    bool hasWindow;
    #endregion
}

// 非汽車類別資料