using System.Diagnostics;
using UnityEngine;

/// <summary>
/// �ǲ߫D�R�AAPI
/// �D�R�A nonstatic
/// ���骫��A�s�b�C��������������
/// 1.���o�R�A�y�k
/// 2.�s���R�A�y�k
/// 3.�ϥ��R�A�y�k
/// </summary>
public class learnAPInonstatic : MonoBehaviour
{
    public Transform traCar1;
    public GameObject goCar;

    private void Start()
    {
        #region �о�
        //�R�A�P�D�R�A���̤j�t��
        //1.�D�R�A�ݭn�@�ӹ��骫��s�b
        //2.�w�q �@�����
        //3.�x�s�Ө��骫��
        //���骫��:
        //1.�C������Game Object :�b Hierarchy �����զ�u�عϥܪ���
        //2.�w�m�� Prefab :�b Hierarchy �����Ŧ�[���ϥܪ���   
        //3.���� Component:1 �P 2 �ݩʭ��O�W�i���|��

        //�D�ݩʻy�k
        //1.���o get
        //���W��.�D�R�A�ݩʦW�� 
        print("�c��������m" + traCar1.position);

        //2.�s�� set
        //���W��.�D�R�A�ݩʦW�� ���w ��;
        transform.position = new Vector3(-5, 3, 1);

        //�R�A��k�y�k
        //3. �ϥ�
        //���ϥ�. �D�R�A�ݩʦW��(�������޼�);
        goCar.SetActive(false);
        #endregion
    }
}

