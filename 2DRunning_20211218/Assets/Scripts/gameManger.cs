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
    [Header("���`�ʵe�Ѽ�")]
    public string parameterDead = "Ĳ�o���`";
    [Header("�L���ϰ�W��")]
    public string namepass = "�ӧQ�ϰ�";



    private int score;
    private float hpMax;
    private Animator ani;
    private Player player;
    
    private void Start()
    {
        ani = GetComponent<Animator>();
        player = GetComponent<Player>();
        hpMax = hp;              //�C���}�l�ɪ���q
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
        hp = Mathf.Clamp(hp, 0, hpMax);
        imgHp.fillAmount = hp / hpMax;
        lose();
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
        lose();

    }

    private void lose()
    {
        if (hp == 0 && groupfinal.alpha==0) //�p�G��q����0 �I���z���׵���0
        {
            textFinalTitle.text = "You died";

            groupfinal.interactable = true;

            ani.SetTrigger(parameterDead);
            player.enabled = false;
            //���𭫽ƩI�s("��k�W��",����ɶ�,���j)
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

        if(collision.name == namepass)
        {
            Win();
        }


    }

}

