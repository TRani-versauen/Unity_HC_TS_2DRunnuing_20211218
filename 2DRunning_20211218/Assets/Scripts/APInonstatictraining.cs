using UnityEngine;

/// <summary>
/// �ۦ�m��API �m�ߤ��e �Ѯv�����ؼ�
/// �j�Munity API ...  �o���Ϊk https://docs.unity3d.com/ScriptReference/Application.OpenURL.html
/// ���e���} https://paper.dropbox.com/doc/C--Bcrdn9p5SYb9TaBIe25z5bexAg-EsPpCQXko0Vt7P1tmH9so
/// </summary>
public class APInonstatictraining : MonoBehaviour
{
    public Camera cam;
    public SpriteRenderer spr;
    public Transform banana;
    public Rigidbody2D apple;

    void Start()
    {
        //�����v�����`
        print("�D��v�����`" + cam.depth);
        //���o�_���G���C��
        print("�_���G���C��" + spr.color);
        //��v�����I���C�� (�H���C��)
        cam.backgroundColor = Random.ColorHSV();
        spr.flipY = true;

    }

    void Update()
    {
        //����������
        banana.Rotate(0, 0, 5);
        //��ī�G�H�[�t�ת��覡�V�W����
        apple.AddForce(new Vector2(0,10));
    }
}
