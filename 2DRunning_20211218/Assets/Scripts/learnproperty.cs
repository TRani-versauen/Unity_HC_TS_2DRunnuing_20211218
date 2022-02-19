using UnityEngine;

/// <summary>
/// 學習屬性
/// </summary>
public class learnproperty : MonoBehaviour
{
    //屬性語法 : 修飾詞 資料屬性 屬性名稱
    //開速完成方法 prop + tab*2
    //get 取得
    //set 存放
    public int lv { get; set; }

    public string passwordField;
    
    //唯獨屬性
    //唯獨屬性給予值的語法: get => 值 ;
    public string passwordProperty{ get => "555"; }

    private void Start()
 
    {
        //存放屬性get
        lv = 100;
        //取得屬性set
        print("level" + lv);

        //存取屬性
        passwordField = "1234567";
        print("取得欄位密碼:" + passwordField);

        //存取屬性
        //passwordproperty = "1234567";     //唯獨屬性不能指定值
        print("取得屬性密碼:" + passwordProperty);


    }
}