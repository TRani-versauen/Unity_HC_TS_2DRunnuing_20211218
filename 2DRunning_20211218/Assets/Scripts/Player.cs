using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 橫向卷軸角色跑庫動作
/// </summary>
public class Player : MonoBehaviour
{
    [Header("音效")]
    public AudioClip soundJump;
    public AudioClip soundSlide;

    private AudioSource aud;

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

    [Header("檢查地板位移")]
    public Vector3 v3GroundOffset;
    [Header("檢查地板尺寸")]
    public Vector3 v3GroundSize = Vector3.one;
    [Header("地板的圖層")]
    public LayerMask layerground;
    [Header("滑行案鍵")]
    public KeyCode keySlide = KeyCode.DownArrow;

    private CapsuleCollider2D cc2d;

    //private Animation aniOld;  舊版
    //private Animator  aniNew;  新版

    private Animator ani;

    #region 事件

    //繪製圖示事件:在Unity內繪製輔助用圖示, 包含:線,方形,圓形等 (執行檔不會顯示)
    private void OnDrawGizmos()
    {
        //決定圖示顏色
        Gizmos.color = new Color(1, 1, 1);
        //2.繪製圖示
        //圖示繪製方體(中心點,尺寸)
        Gizmos.DrawCube(transform.position + v3GroundOffset, v3GroundSize);
    }

    private void Start()
    {
       //GetComponent<元件類型>()    <>為 "泛型" 可以為所有類型
       //指定元件
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        cc2d = GetComponent<CapsuleCollider2D>();
        aud = GetComponent<AudioSource>();
    }

    private void Update()
    {
        Run();
        Jump();
        Slide();
    }
    #endregion

    #region 方法
    /// <summary>
    /// 跑步
    /// </summary>
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
    
    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        bool inputjump = Input.GetKeyDown(KeyJump);
        //print("是否跳躍" + inputjump);

        //如果按下跳躍 並且跳躍次數大於0 就可以往上跳
        if(inputjump && CountJump>0)
        {
            rig.AddForce(new Vector2(0, jump));

            CountJump--;

            ani.SetTrigger(parameterJump);

            aud.PlayOneShot(soundJump);
        }

        // 2D 碰撞 = 2D 物理.方形覆蓋(中心點,尺寸,角度)
        Collider2D hit = Physics2D.OverlapBox(transform.position + v3GroundOffset, v3GroundSize, 0,layerground);
        if (hit && rig.velocity.y<0)
            CountJump = CountJumpMax;
    }

    private void Slide()
    {
        //判斷是否按下滑行
        //更新滑行動畫
        //更新碰撞器
        if (Input.GetKey(keySlide))
        {
            ani.SetBool(parameterslide, true);
            //滑行 offset (0.2,-0.8) Size(2,1.3) h
            cc2d.offset = new Vector2(0.2f, -0.8f);
            cc2d.size = new Vector2(2, 1.3f);
            cc2d.direction = CapsuleDirection2D.Horizontal;

            if(!aud.isPlaying) aud.PlayOneShot(soundSlide,0.5f);
        }
        else
        {
            ani.SetBool(parameterslide, false);
            //站立 offset (0.2,-0.2) Size(1,2.5) v
            cc2d.offset = new Vector2(0.2f, -0.2f);
            cc2d.size = new Vector2(1, 2.5f);
            cc2d.direction = CapsuleDirection2D.Vertical;
        }
    }

    
    #endregion

}