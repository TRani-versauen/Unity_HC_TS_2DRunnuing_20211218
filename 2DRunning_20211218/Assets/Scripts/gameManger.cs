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

    private int score;
    private float hpMax;

    private void Update()
    {
        UpdateTimeUI();
    }

    private void UpdateTimeUI()
    {
        print("當前場景時間" + Time.timeSinceLevelLoad);
    }
}

