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
    [Header("���D����"), Range(0, 500)]
    public int jump = 500;
    [Tooltip("�x�s����O�_�Ʀ�")]
    public bool isslide;
    [Tooltip("�x�s����O�_���`")]
    public bool isdead;


    public string parameterJump = "Ĳ�o���D";
    public string parameterslide = "�}���Ʀ�";
    public string parameterdead = "Ĳ�o���`";
    #endregion

    public Transform traPlayer;
    
    public KeyCode KeyJump = KeyCode.Space;

    //���O�ݩ�... Debug �Ҧ��i�H�ݨ����ê�����
    private Rigidbody2D  rig;
    [Header("���D�q�Ƴ̤j��"), Range(0, 5)]
    public int  CountJumpMax = 2;

    public int CountJump ;

    private void Start()
    {
       //GetComponent<��������>()    <>�� "�x��" �i�H���Ҧ�����
       //���w����
        rig = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        Run();
        Jump();
    }

    #region �]�B

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
        bool inputjump = Input.GetKeyDown(KeyJump);
        //print("�O�_���D" + inputjump);

        //�p�G���U���D �åB���D���Ƥj��0 �N�i�H���W��
        if(inputjump && CountJump>0)
        {
            rig.AddForce(new Vector2(0, jump));

            CountJump--;
        }

        
    }
    #endregion
}


