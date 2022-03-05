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
    [Header("跳躍高度"), Range(0, 500)]
    public int jump = 500;
    [Tooltip("儲存角色是否滑行")]
    public bool isslide;
    [Tooltip("儲存角色是否死亡")]
    public bool isdead;


    public string parameterJump = "觸發跳躍";
    public string parameterslide = "開關滑行";
    public string parameterdead = "觸發死亡";
    #endregion

    public Transform traPlayer;
    
    public KeyCode KeyJump = KeyCode.Space;

    //面板屬性... Debug 模式可以看到隱藏的元件
    private Rigidbody2D  rig;
    [Header("跳躍段數最大值"), Range(0, 5)]
    public int  CountJumpMax = 2;

    public int CountJump ;

    private void Start()
    {
       //GetComponent<元件類型>()    <>為 "泛型" 可以為所有類型
       //指定元件
        rig = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        Run();
        Jump();
    }

    #region 跑步

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
        bool inputjump = Input.GetKeyDown(KeyJump);
        //print("是否跳躍" + inputjump);

        //如果按下跳躍 並且跳躍次數大於0 就可以往上跳
        if(inputjump && CountJump>0)
        {
            rig.AddForce(new Vector2(0, jump));

            CountJump--;
        }

        
    }
    #endregion
}


