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
    [Header("�D��")]
    public string tagProp = "�D��";


    private int score;
    private float hpMax;

    private void Update()
    {
        UpdateTimeUI();
        UpdateHpUI();
    }

    private void Start()
    {
        hpMax = hp;              //�C���}�l�ɪ���q
    }

    /// <summary>
    /// ��s�ɶ�����
    /// </summary>
    private void UpdateTimeUI()
    {
        //print("��e�����ɶ�" + Time.timeSinceLevelLoad);
        //ToString("F1")�Ʀr��ܤp���I��X���
        textTime.text = "�ɶ�:" + Time.timeSinceLevelLoad.ToString("F1");
    }

    /// <summary>
    /// ��s��q����
    /// </summary>
    private void UpdateHpUI()
    {
        hp -= Time.deltaTime;
        imgHp.fillAmount = hp / hpMax;
    }

    private void AddScoreAndUpdateUI()
    {
        score += 100;
        textScore.text = "����" + score;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("���a�I��:" + collision.name);
        if (collision.tag == tagProp)
        {
            AddScoreAndUpdateUI();
            Destroy(collision.gameObject);
        }
    }

    
}

