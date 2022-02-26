using UnityEngine;

/// <summary>
/// �ۦ�m��API �m�ߤ��e �Ѯv�����ؼ�
/// �j�Munity API ...  �o���Ϊk https://docs.unity3d.com/ScriptReference/Application.OpenURL.html
/// ���e���} https://paper.dropbox.com/doc/C--Bcqr9juySGNcnwbnJU5KkZVIAg-rEKAPFSoMNq3GOxEx45vY
/// </summary>
public class APIstatictraining : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        #region//���o
        //��ܩҦ���v�����ƶq
        print("�Ҧ���v���ƶq" + Camera.allCamerasCount); 
        
        //���2D�����O�j�p
        print("2D �����O�j�p" + Physics2D.gravity);
        
        //��ܶ�P�v
        print("��P�v" + Mathf.PI);
        #endregion

        #region//�s��
        //�N���O�]�w��-20
        Physics2D.gravity = new Vector2(0, -20);
        
        //�ɶ��t�׬�0.5��
        Time.timeScale = 0.5f;

        #endregion

        #region//�ϥ�
        //�h9.999�p���I
        float number9999 = Mathf.Ceil(9.999f);   //Ceil = �L����i��  //Round �|�ˤ��J //Floor �L����˥h
        print("�h9.999�p���I=" + number9999);
       
        //�p��a , b�I���Z��
        Vector3 a = Vector3.one;
        Vector3 b = Vector3.one * 22;
        float dis = Vector3.Distance(a, b);
        print("a�I�Mb�I���Z��" + dis);

        //�O�_���U���N��
        print("�O�_���U���N��" + Input.anyKey);

        //�}�Һ���
        Application.OpenURL("https://unity.com/");

        #endregion
    }
    void Update()
    {
        #region//���o
        //�O�_���U�ť���
        print("�O�_���U���N��" + Input.anyKey);

        //��ܸg�L���ɶ�
        //print("�g�L�ɶ�" + Time.time);

        #endregion

        #region //�s��
        #endregion   //�]���s������

        #region//�ϥ�
        //�O�_���U�ť���
        print("�O�_���U�ť���" + Input.GetKeyDown(KeyCode.Space));
        #endregion
    }
}
