using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ۦ�m��API �m�ߤ��e �Ѯv�����ؼ�
/// ���e���} https://paper.dropbox.com/doc/C--Bcqr9juySGNcnwbnJU5KkZVIAg-rEKAPFSoMNq3GOxEx45vY
/// </summary>
public class APIstatictraining : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        #region//���o
        print("�Ҧ���v���ƶq" + Camera.allCamerasCount);
        print("2D �����O�j�p" + Physics2D.gravity);
        print("��P�v" + Mathf.PI);
        #endregion

        #region//�s��
        Physics2D.gravity = new Vector2(0, -20);
        Time.timeScale = 0.5f;

        #endregion

        #region//�ϥ�
        float number9999 = Mathf.Ceil(9.999f);   //Ceil = �L����i��  //Round �|�ˤ��J //Floor �L����˥h
        print("�h9.999�p���I=" + number9999);
        Vector3 a = Vector3.one;
        Vector3 b = Vector3.one * 22;
        float dis = Vector3.Distance(a , b);
        print("a�I�Mb�I���Z��" + dis);
        #endregion


        void Update()
    {
            #region//���o
            print("�O�_���U���N��" + Input.anyKey);
            print("�g�L�ɶ�" + Time.time);
            #endregion
            
            #region//�s��
            #endregion
            
            #region//�ϥ�
            #endregion
        }
    }
