using UnityEngine;
using UnityEngine.SceneManagement; // �ޥγ����޲z �R�W�Ŷ�, �i�H�ϥ�API

/// <summary>
/// ��������
/// �i�H��������
/// �i�H���}�C��
/// </summary>
public class scenecontrol : MonoBehaviour
{
    /// <summary>
    /// ���J����
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene("���d 1");
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
