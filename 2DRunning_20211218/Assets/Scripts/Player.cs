using UnityEditor.Timeline;
using UnityEngine;

/// <summary>
/// ��V���b����]�w�ʧ@
/// </summary>
public class Player : MonoBehaviour
{
    #region
    //�H���t�סB���D���סB�O�_�Ʀ�B�O�_���`
    //�ʵe�ѼƸ��D�A�Ʀ�P���`
    //�ݩ�attribute
    //���Dheader
    //�d��range
    //����tooltip
    [Header("�]�B�t��"), Range(0, 500)]
    public float Speed = 1.5f;
    [Header("���D����"), Range(0, 50)]
    public int jump = 50;
    [Tooltip("�x�s����O�_�Ʀ�")]
    public bool isslide;
    [Tooltip("�x�s����O�_���`")]
    public bool isdead;


    public string parameterJump = "Ĳ�o���D";
    public string parameterslide = "�}���Ʀ�";
    public string parameterdead = "Ĳ�o���`";
    #endregion

    public Transform traPlayer;
    [Header("���D����")]
    public KeyCode KeyJump = KeyCode.Space;

    #region �]�B


    public void Update()
    {
        Run();
    }

    private void Run()
    {
        //�s��transfrom���Ĥ@�ؤ覡
        //���a�ܧ�.�첾(x,y,z)
        //Time.deltalTime �@�V���ɶ�
        //traPlayer.Translate(Speed*Time.deltaTime, 0, 0);

        //�s��transfrom���ĤG�ؤ覡
        //����: ��n���Transform �P������P�@���h
        //�y�k:
        //transForm.�����W��
        transform.Translate(Speed * Time.deltaTime, 0, 0);
    }
    #endregion

    #region ���D
    private void Jump()
    {

    }
    #endregion
}


