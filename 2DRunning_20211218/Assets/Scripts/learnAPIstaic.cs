
using System;
using UnityEngine;

/// <summary>
/// �ǲ��R�AAPI
/// �R�A static
/// �D���骫��A���s�b�C��������������
/// 1.���o�R�A�y�k
/// 2.�s���R�A�y�k
/// 3.�ϥ��R�A�y�k
/// </summary>
public class learnAPIstaic : MonoBehaviour
{
    private void Start()
    {
        //1.�R�A�ݩʻy�k
        //���o Get
        //���O�W��.�R�A�ݩʦW��
        print("��P�v" + Mathf.PI);
        print("�L���j" + Mathf.Infinity);

        //2.�s�� Set
        //���O�W��.�R�A�ݩʦW�� ���w ��;
        //athf.Infinity PI = 9.99999f;      //�߿W�ݩʤ���s��
        Cursor.visible = false;             //�ƹ�����

        //3.�ϥ��R�A�y�k
        //���O�W��.�R�A��k�W��(�������޼�);
        float number777 = Math.Abs(-7.77f);
        print("-7.77�������=" + number777);

    }
}
    

