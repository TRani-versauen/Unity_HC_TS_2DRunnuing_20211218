using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

/// <summary>
/// �ǲߤ�k
/// </summary>
public class learnmathod : MonoBehaviour
{
    //��k�y�k
    //�׹��� �Ǧ^������� ��k�W�� () {�{�����e�B���z�ơB�t��k}
    //void �L�Ǧ^ :�ϥΦ���k���|����Ʀ^��

    //�ۭq��k
    private void Start()
    {
        //�I�s�ۭq��k
        //�ۭq��k�W��()
        Test();
        ShootFire();
        ShootIce();
        //���X�ӰѼƴN�n��J�X�Ӥ޼�
        //���w�]�Ȫ��Ѽƥi�H���ε��޼�

        Shoot("���y", 170, effect: "�U�N");
        Shoot("�B�y", 80);
        Shoot("�q�y", 300, "�p�q����");
        int water3 = BuyWater(3);
        float TRani = BMI(70, 1.7f);
        print("TRani BMI" + TRani);





    }

    //�ۭq��k:���|�۰ʰ���
    //�|�۰ʰ��檺�s���ƥ�
    private void Test()
    {
        print("Test");
    }


    //�o�g���y�M�o�g�B�y�B�o�g�q�y
    private void ShootFire()
    {
        print("�o�g���y");
        print("����t�� 100");
        print("�o�g����");
    }

    private void ShootIce()
    {
        print("�o�g�B�y");
        print("����t�� 50");
        print("�o�g����");
    }

    //���@�ʻP�X�R��
    //�Ѽƻy�k:�Ѽ�1���� �Ѽ�1�W��, �Ѽ�2���� �Ѽ�2�W��
    private void Shoot(string type, int speed, string sound = "�w�]����", string effect = "�z��")
    {
        print("<color=yellow>�o�g" + type + "</color>");
        print("<color=yellow>����t��" + speed + "</color>");
        print("<color=yellow>�n��" + sound + "</color>");
        print("<color=yellow>�S��" + effect + "</color>");
    }
    private int BuyWater(int count)
    {

        print("�R" + count + "��");
        print("��O" + count * 50 + "��");
        int price = count * 50;
        return price;


    }
    private float BMI(float weight, float height)
    {
        float result = weight / (height * height);
        return result;
    }

}