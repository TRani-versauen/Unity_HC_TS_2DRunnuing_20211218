using System.Threading;
using UnityEngine;

/// <summary>
///認識迴圈
///while
///do while
///for
///foreach
/// </summary>
public class learnloop : MonoBehaviour
{
    public int[] scores = new int[20];
    //迴圈的作用 : 使一個指令重複n次
    private void Start()
    {

        #region while和for的用法
        //舉例:輸出五次hello的方法
        print("hello");
        print("hello");
        print("hello");
        print("hello");
        print("hello");
        //使用迴圈的方法
        //如同使用if的方法  if:的方法 (布林值) {程式區塊}
        //使用while的方法  while (布林值) {程式區塊}
        
        //當布林值為true時，執行一次
        if (true)
        {
            print("hi");
        }
        //當布林值為true時，重複執行  電腦會無回應
        /*
        while (true)
        {
            print("hi");        
        }
        */
        int Count = 0;
        while (Count < 5)
        {
            print("你好");
            Count++;
        }

        //for(初始值,布林值,迴圈結束的方式)
        for (int i = 0; i < 5; i++)
        {
            print("再會");
        }

        //for 輸入100~200中每隔2的數字 
        for (int i = 100; i <201; i+=2)
        {
            print("輸入數字:" + i);
        }
        #endregion
        //迴圈與列陣的應用
        for (int i = 0; 1<scores.Length; i++)
        {
            scores[i] = 70 + i;

        }
    }
    
    
    
    
}
