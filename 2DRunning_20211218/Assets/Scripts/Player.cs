using UnityEditor.Timeline;
using UnityEngine;

/// <summary>
/// 橫向卷軸角色跑庫動作
/// </summary>
public class Player : MonoBehaviour
{
    #region
    //人物速度、跳躍高度、是否滑行、是否死亡
    //動畫參數跳躍，滑行與死亡
    //屬性attribute
    //標題header
    //範圍range
    //提示tooltip
    [Header("跑步速度"), Range(0, 500)]
    public float Speed = 1.5f;
    [Header("跳躍高度"), Range(0, 50)]
    public int jump = 50;
    [Tooltip("儲存角色是否滑行")]
    public bool isslide;
    [Tooltip("儲存角色是否死亡")]
    public bool isdead;


    public string parameterJump = "觸發跳躍";
    public string parameterslide = "開關滑行";
    public string parameterdead = "觸發死亡";
    #endregion

    public Transform traPlayer;
    [Header("跳躍案鍵")]
    public KeyCode KeyJump = KeyCode.Space;

    #region 跑步


    public void Update()
    {
        Run();
    }

    private void Run()
    {
        //存取transfrom的第一種方式
        //玩家變形.位移(x,y,z)
        //Time.deltalTime 一幀的時間
        //traPlayer.Translate(Speed*Time.deltaTime, 0, 0);

        //存取transfrom的第二種方式
        //條件: 當要控制的Transform 與此元件同一階層
        //語法:
        //transForm.成員名稱
        transform.Translate(Speed * Time.deltaTime, 0, 0);
    }
    #endregion

    #region 跳躍
    private void Jump()
    {

    }
    #endregion
}


