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

        #endregion


    }

}