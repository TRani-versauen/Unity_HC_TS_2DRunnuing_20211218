using UnityEngine;
using UnityEngine.UI;

public class gameManger : MonoBehaviour
{
    [Header("血量")]
    public Image imgHp;
    [Header("時間")]
    public Text textTime;
    [Header("分數")]
    public Text textScore;
    [Header("玩家血量"), Range(0, 5000)]
    public float hp = 100;
    [Header("道具")]
    public string tagProp = "道具";
    [Header("陷阱")]
    public string tagTrap = "陷阱";
    [Header("結束畫面")]
    public CanvasGroup groupfinal;
    [Header("結束畫面標題")]
    public Text textFinalTitle;
    [Header("顯示結束畫面間隔"), Range(0, 0.5f)]
    public float showFinalInterval = 0.1f;
    [Header("死亡動畫參數")]
    public string parameterDead = "觸發死亡";
    [Header("過關區域名稱")]
    public string namepass = "勝利區域";



    private int score;
    private float hpMax;
    private Animator ani;
    private Player player;
    
    private void Start()
    {
        ani = GetComponent<Animator>();
        player = GetComponent<Player>();
        hpMax = hp;              //遊戲開始時的血量
    }


    private void Update()
    {
        UpdateTimeUI();
        UpdateHpUI();
    }


    private void ShowFinal()
    {
        groupfinal.alpha += 0.2f;
    }

    /// <summary>
    /// 更新時間介面
    /// </summary>
    private void UpdateTimeUI()
    {
        //print("當前場景時間" + Time.timeSinceLevelLoad);
        //ToString("F1")數字表示小數點後幾位數
        textTime.text = "時間:" + Time.timeSinceLevelLoad.ToString("F1");
    }

    /// <summary>
    /// 更新血量介面
    /// </summary>
    private void UpdateHpUI()
    {
        hp -= Time.deltaTime;
        hp = Mathf.Clamp(hp, 0, hpMax);
        imgHp.fillAmount = hp / hpMax;
        lose();
    }

    private void AddScoreAndUpdateUI(int add)
    {
        score += add;
        textScore.text = "分數" + score;
    }

    private void ChangeHpAndUpdateUI(float value)
    {
        hp += value;
        hp = Mathf.Clamp(hp, 0, hpMax);
        imgHp.fillAmount = hp / hpMax;
        lose();

    }

    private void lose()
    {
        if (hp == 0 && groupfinal.alpha==0) //如果血量等於0 背景透明度等於0
        {
            textFinalTitle.text = "You died";

            groupfinal.interactable = true;

            ani.SetTrigger(parameterDead);
            player.enabled = false;
            //延遲重複呼叫("方法名稱",延遲時間,間隔)
            InvokeRepeating("ShowFinal", 0, showFinalInterval);
        }
    }

    private void Win()
    {        
        
        {
            textFinalTitle.text = "You win";

            groupfinal.interactable = true;

            player.enabled = false;
            
            InvokeRepeating("ShowFinal", 0, showFinalInterval);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("玩家碰到:" + collision.name);
        if (collision.tag == tagProp)
        {
            AddScoreAndUpdateUI(collision.GetComponent<Prop>().Score);
            if (collision.name.Contains("草莓")) ChangeHpAndUpdateUI(10);
            Destroy(collision.gameObject);
        }

        if (collision.tag == tagTrap)
        {
            ChangeHpAndUpdateUI(-collision.GetComponent<Trap>().Damage);
        }

        if(collision.name == namepass)
        {
            Win();
        }


    }

}

