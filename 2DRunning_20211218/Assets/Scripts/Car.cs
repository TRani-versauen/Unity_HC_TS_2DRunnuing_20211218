using UnityEngine;  // 引用 Unity 引擎空間，讓我們可以使用裡面的 API (倉庫)

// 類別 類別名稱 (必須與檔案名稱完全一致，大小寫也是)
public class Car : MonoBehaviour
{
    // 此類別的內容

    #region 欄位 Field
    // ※ 欄位語法
    // 修飾詞 資料類型 欄位名稱 (指定 預設值) 結尾
    // ※ 四大常用資料類型
    // 整　數 int
    // 浮點數 float
    // 字　串 string
    // 布林值 bool
    // ※ 修飾詞
    // 私人：不給外部類別存取，預設，不顯示 private
    // 公開：允許外部類別存取，顯示 public
    public int cc = 1000;
    public float weight = 3.5f;     // f 或 F 
    public string brand = "賓士";   // "" 包覆
    public bool hasWindow = true;   // true、false

    // ※ Unity 內常用的資料類型
    // 顏色 Color
    public Color colorA;
    public Color yellow = Color.yellow;
    public Color magenta = Color.magenta;
    public Color colorB = new Color(0.5f, 0, 0.5f);
    public Color colorC = new Color(0, 0.5f, 0.5f, 0.5f);
    // 向量 Vector 2 ~ 4
    public Vector2 vector2;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Up = Vector2.up;
    public Vector2 v2One = Vector2.one;
    public Vector2 vector2A = new Vector2(3.5f, 9.5f);
    #endregion
    public KeyCode jump = KeyCode.Space;

}

// 非汽車類別資料