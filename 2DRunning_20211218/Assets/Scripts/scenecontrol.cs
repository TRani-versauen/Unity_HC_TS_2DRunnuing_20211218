using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 切換場景
/// 可以切換場景
/// 可以離開遊戲
/// </summary>
public class scenecontrol : MonoBehaviour
{
    /// <summary>
    /// 載入場景
    /// </summary>
    private void LoadScence()
    {

    }

    //讓按鈕跟程式溝通的方法
    //1.公開方法
    //2.按鈕 Button 元件 on click 可以指定此方法
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();    //應用程式.離開- 關閉應用程式 unity不執行
    }
     
}
