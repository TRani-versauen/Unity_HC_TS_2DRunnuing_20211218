using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ��V���b����]�w�ʧ@
/// </summary>
public class Player : MonoBehaviour
{
    [Header("����")]
    public AudioClip soundJump;
    public AudioClip soundSlide;

    private AudioSource aud;

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

    [Header("�ˬd�a�O�첾")]
    public Vector3 v3GroundOffset;
    [Header("�ˬd�a�O�ؤo")]
    public Vector3 v3GroundSize = Vector3.one;
    [Header("�a�O���ϼh")]
    public LayerMask layerground;
    [Header("�Ʀ����")]
    public KeyCode keySlide = KeyCode.DownArrow;

    private CapsuleCollider2D cc2d;

    //private Animation aniOld;  �ª�
    //private Animator  aniNew;  �s��

    private Animator ani;

    #region �ƥ�

    //ø�s�ϥܨƥ�:�bUnity��ø�s���U�ιϥ�, �]�t:�u,���,��ε� (�����ɤ��|���)
    private void OnDrawGizmos()
    {
        //�M�w�ϥ��C��
        Gizmos.color = new Color(1, 1, 1);
        //2.ø�s�ϥ�
        //�ϥ�ø�s����(�����I,�ؤo)
        Gizmos.DrawCube(transform.position + v3GroundOffset, v3GroundSize);
    }

    private void Start()
    {
       //GetComponent<��������>()    <>�� "�x��" �i�H���Ҧ�����
       //���w����
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        cc2d = GetComponent<CapsuleCollider2D>();
        aud = GetComponent<AudioSource>();
    }

    private void Update()
    {
        Run();
        Jump();
        Slide();
    }
    #endregion

    #region ��k
    /// <summary>
    /// �]�B
    /// </summary>
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
    
    /// <summary>
    /// ���D
    /// </summary>
    private void Jump()
    {
        bool inputjump = Input.GetKeyDown(KeyJump);
        //print("�O�_���D" + inputjump);

        //�p�G���U���D �åB���D���Ƥj��0 �N�i�H���W��
        if(inputjump && CountJump>0)
        {
            rig.AddForce(new Vector2(0, jump));

            CountJump--;

            ani.SetTrigger(parameterJump);

            aud.PlayOneShot(soundJump);
        }

        // 2D �I�� = 2D ���z.����л\(�����I,�ؤo,����)
        Collider2D hit = Physics2D.OverlapBox(transform.position + v3GroundOffset, v3GroundSize, 0,layerground);
        if (hit && rig.velocity.y<0)
            CountJump = CountJumpMax;
    }

    private void Slide()
    {
        //�P�_�O�_���U�Ʀ�
        //��s�Ʀ�ʵe
        //��s�I����
        if (Input.GetKey(keySlide))
        {
            ani.SetBool(parameterslide, true);
            //�Ʀ� offset (0.2,-0.8) Size(2,1.3) h
            cc2d.offset = new Vector2(0.2f, -0.8f);
            cc2d.size = new Vector2(2, 1.3f);
            cc2d.direction = CapsuleDirection2D.Horizontal;

            if(!aud.isPlaying) aud.PlayOneShot(soundSlide,0.5f);
        }
        else
        {
            ani.SetBool(parameterslide, false);
            //���� offset (0.2,-0.2) Size(1,2.5) v
            cc2d.offset = new Vector2(0.2f, -0.2f);
            cc2d.size = new Vector2(1, 2.5f);
            cc2d.direction = CapsuleDirection2D.Vertical;
        }
    }

    
    #endregion

}