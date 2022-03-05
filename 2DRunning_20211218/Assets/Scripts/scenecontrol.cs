using UnityEngine;
using UnityEngine.SceneManagement; // 引用場景管理 命名空間, 可以使用API

/// <summary>
/// 切換場景
/// 可以切換場景
/// 可以離開遊戲
/// </summary>
public class scenecontrol : MonoBehaviour
{
   public void DelyaLoadScene()
    {
        //使用MonoBehaviour的API語法:
        //方法名稱(對應引數);
        Invoke("LoadScene", 1.5f); //延遲呼叫("方法名稱",持續秒數) -延遲1.5秒呼叫LoadScene   
    }
    
    /// <summary>
    /// 載入場景
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene("關卡 1");
    }

    public void DelyaQuitGame()
    {
        //使用MonoBehaviour的API語法:
        //方法名稱(對應引數);
        Invoke("QuitGame", 1.5f); //延遲呼叫("方法名稱",持續秒數) -延遲1.5秒呼叫QuitGame   
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
