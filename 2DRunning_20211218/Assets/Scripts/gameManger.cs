using UnityEngine;
using UnityEngine.UI;

public class gameManger : MonoBehaviour
{
    [Header("��q")]
    public Image imgHp;
    [Header("�ɶ�")]
    public Text textTime;
    [Header("����")]
    public Text textScore;
    [Header("���a��q"), Range(0, 5000)]
    public float hp = 100;

    private int score;
    private float hpMax;

    private void Update()
    {
        UpdateTimeUI();
    }

    private void UpdateTimeUI()
    {
        print("��e�����ɶ�" + Time.timeSinceLevelLoad);
    }
}

