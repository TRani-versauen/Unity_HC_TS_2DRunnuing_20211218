using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class learnoperator : MonoBehaviour
{
    public float a = 1;
    public float b = 3;
    public float c = 5;
    public float d = 4;
    public float e = 1;

    private void Start()
    {
        #region �B��l:�ƾ�
        // �[ +
        print("�W�[:" + (a + b));
        // �� -
        print("���:" + (a - b));
        // �� *
        print(":��" + (a * b));
        // �� /
        print("��:" + (a / b));
        // �l %
        print("�l:" + (a % b));
        #endregion

        #region �B��l:���
        // �j��   >
        print("�j��:" + (c > d));
        // �p��   <
        print("�p��:" + (c < d));
        // �j�󵥩�  >=
        print("�j�󵥩�:" + (c >= d));
        // �p�󵥩�   <=
        print("�p�󵥩�:" + (c <= d));
        // ����   ==
        print("����:" + (c == d));
        // ������  !=
        print("������:" + (c != d));


        #endregion

        #region �B��l:�޿�
        //�åB &&(shift+7)
        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);
        //�Ϊ� ||(shift|)
        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);

        //�A�� !
        print(!true);
        print(!false);

        //���Ʀr�[1
        e = e + 1;
        print("e�����G" + e);
        //�ֳt�[1
        e++;
        //�ֳt��1
        e--;

        //�����[����l
        e += 10;  //�[10
        e -= 10; //��10
        e *= 10; //��10
        e /= 10; //��10
        e %= 10; //�l10

        
        #endregion


    }

}