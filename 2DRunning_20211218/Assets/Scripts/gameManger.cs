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


    private int score;
    private float hpMax;

    private void Update()
    {
        UpdateTimeUI();
        UpdateHpUI();
    }

    private void Start()
    {
        hpMax = hp;              //遊戲開始時的血量
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
        imgHp.fillAmount = hp / hpMax;
    }

    private void AddScoreAndUpdateUI()
    {
        score += 100;
        textScore.text = "分數" + score;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("玩家碰到:" + collision.name);
        if (collision.tag == tagProp)
        {
            AddScoreAndUpdateUI();
            Destroy(collision.gameObject);
        }
    }

    
}

