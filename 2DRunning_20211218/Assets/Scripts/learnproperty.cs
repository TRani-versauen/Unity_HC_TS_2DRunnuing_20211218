using UnityEngine;

/// <summary>
/// �ǲ��ݩ�
/// </summary>
public class learnproperty : MonoBehaviour
{
    //�ݩʻy�k : �׹��� ����ݩ� �ݩʦW��
    //�}�t������k prop + tab*2
    //get ���o
    //set �s��
    public int lv { get; set; }

    public string passwordField;
    
    //�߿W�ݩ�
    //�߿W�ݩʵ����Ȫ��y�k: get => �� ;
    public string passwordProperty{ get => "555"; }

    private void Start()
 
    {
        //�s���ݩ�get
        lv = 100;
        //���o�ݩ�set
        print("level" + lv);

        //�s���ݩ�
        passwordField = "1234567";
        print("���o���K�X:" + passwordField);

        //�s���ݩ�
        //passwordproperty = "1234567";     //�߿W�ݩʤ�����w��
        print("���o�ݩʱK�X:" + passwordProperty);


    }
}