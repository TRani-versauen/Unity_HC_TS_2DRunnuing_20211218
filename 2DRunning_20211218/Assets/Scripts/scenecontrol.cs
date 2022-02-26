using UnityEngine;
using UnityEngine.SceneManagement; // 引用場景管理 命名空間, 可以使用API

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
    public void LoadScene()
    {
        SceneManager.LoadScene("關卡 1");
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
