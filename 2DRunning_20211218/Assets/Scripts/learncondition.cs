using UnityEngine;

/// <summary>
/// �ǲߧP�_��
/// 1.if
/// 2.switch
/// </summary>
public class learncondition : MonoBehaviour
{
    public bool haskey = true;

    private int health = 0;

    public string gear;


    //�C�|enum (�U�Ԧ����)
    //1.�w�q�C�|
    public enum Mode
    {
        easy, normal, hard
    }
    //2.��@�C�|
    public Mode mode;

    private void Start()
    {
        //if�y�k : if (���L��) {�{���϶��B�t��k�B���z��}
        //�ֳt����: if + tab * 2

        //���L�� ����true �|����{}�̪����O
        //���L�� ����false ���|����{}�̪����O
        #region if�P�_��
        if (true)
        {
            print("�ڬO�P�_��");
        }

        //���L�� ����true �|����if{}�̪����O
        //���L�� ����false �|����else{}�̪����O
        if (haskey)
        {
            print("�i�H�}��");
        }
        else
        {
            print("�L�k�}��");
        }
        #endregion
        #region switch�P�_��
        //switch �y�k
        //switch(�P�_�����)
        //{
        //     case ��1:
        //       �{�����e;
        //       �{�����e;
        //       break;
        //     case ��2:
        //       �{�����e;
        //       �{�����e;
        //       break;
        //     default:
        //       �{�����e;
        //       �{�����e;
        //       break;
        //}
        switch (gear)
        {
            case "��q�[��":
                print("��q�^�_�j��");
                break;
            case "��O�[��":
                print("�ˮ`�W�[");
                print("��O�j��");
                break;
            case "�����[��":
                print("�����W�[");
                break;
        }
        #endregion
        #region switch + enum �P�_��
        // switch + enum
        switch (mode)
        {
            case Mode.easy:
                print("²��Ҧ�");
                break;
            case Mode.normal:
                print("²��Ҧ�");
                break;
            case Mode.hard:
                print("²��Ҧ�");
                break;
        }
        #endregion
    }
    private void Update()
    {
        if (health > 50)
        {
            print("���`���ʳt��");
        }
        else if (health > 10 && health < 50)
        {
            print("��z���ʳt��");
        }
        else if (health <= 10 && health >= 0)
        {
            print("�x�����ʳt��");
        }
    }
}