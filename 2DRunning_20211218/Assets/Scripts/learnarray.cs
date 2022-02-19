using UnityEngine;

public class learnarray : MonoBehaviour
{
    //陣列作用
    //用於儲存多筆"相同類型"的資料

    //使用欄位儲存資料
    //V不使用陣列V
    public int atk1 = 10;
    public int atk2 = 20;
    public int atk3 = 30;
    //V使用陣列V   在資料類型後面加上[]
    public int[] atks;

    //陣列語法
    //陣列數量不指定值
    public float[] speeds = new float[5];
    public string[] props = { "道具一", "道具二", "道具三" };
    public Vector3[] positions = { new Vector3(0, 0, 0), new Vector3(0, 1, 2) };
    public bool[] complete = { true, true, false, false };

    private void Start()
    {
        //1.陣列儲存方式
        //陳列名稱[編號] = 值;
        //將陣列第一筆資料改為100
        atks[0] = 100;
        //2.使用陣列遇到的錯誤:超出陣列範圍
        //atks[1] = 100;

        //3.取得陣列資料
        //陣列名稱[編號]
        print("第二筆道具資料:" + props[1]);
        print("第二筆座標資料:" + positions[1]);
       
        //4.取得陣列數量 Length
        print("布林值陣列的數量:" + complete.Length);

        //有關於時間的補充
        //由0秒開始,每一秒計一次,顯示當下秒數
        InvokeRepeating("PrintNumber", 0, 1);
    }

    int number = 1;

    private void PrintNumber()
    {
        print("數字：" + number);
        number++;
    }
}

