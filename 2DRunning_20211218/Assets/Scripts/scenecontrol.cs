using UnityEngine;
using UnityEngine.SceneManagement; // �ޥγ����޲z �R�W�Ŷ�, �i�H�ϥ�API

/// <summary>
/// ��������
/// �i�H��������
/// �i�H���}�C��
/// </summary>
public class scenecontrol : MonoBehaviour
{
   public void DelyaLoadScene()
    {
        //�ϥ�MonoBehaviour��API�y�k:
        //��k�W��(�����޼�);
        Invoke("LoadScene", 1.5f); //����I�s("��k�W��",������) -����1.5��I�sLoadScene   
    }
    
    /// <summary>
    /// ���J����
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene("���d 1");
    }

    public void DelyaQuitGame()
    {
        //�ϥ�MonoBehaviour��API�y�k:
        //��k�W��(�����޼�);
        Invoke("QuitGame", 1.5f); //����I�s("��k�W��",������) -����1.5��I�sQuitGame   
    }

    //�����s��{�����q����k
    //1.���}��k
    //2.���s Button ���� on click �i�H���w����k
    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();    //���ε{��.���}- �������ε{�� unity������
    }
     
}
