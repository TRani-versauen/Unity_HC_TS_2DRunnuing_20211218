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
    [Header("����")]
    public string tagTrap = "����";
    [Header("�����e��")]
    public CanvasGroup groupfinal;
    [Header("�����e�����D")]
    public Text textFinalTitle;
    [Header("��ܵ����e�����j"), Range(0, 0.5f)]
    public float showFinalInterval = 0.1f;


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

    private void ShowFinal()
    {
        groupfinal.alpha += 0.2f;
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

    private void AddScoreAndUpdateUI(int add)
    {
        score += add;
        textScore.text = "����" + score;
    }

    private void ChangeHpAndUpdateUI(float value)
    {
        hp += value;
        hp = Mathf.Clamp(hp, 0, hpMax);
        imgHp.fillAmount = hp / hpMax;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("���a�I��:" + collision.name);
        if (collision.tag == tagProp)
        {
            AddScoreAndUpdateUI(collision.GetComponent<Prop>().Score);
            if (collision.name.Contains("���")) ChangeHpAndUpdateUI(10);
            Destroy(collision.gameObject);
        }
        
        if (collision.tag == tagTrap)
        {
            ChangeHpAndUpdateUI(-collision.GetComponent<Trap>().Damage);
        }
    }
}

