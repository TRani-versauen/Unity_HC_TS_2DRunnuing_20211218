using UnityEngine;

public class learnarray : MonoBehaviour
{
    //�}�C�@��
    //�Ω��x�s�h��"�ۦP����"�����

    //�ϥ�����x�s���
    //V���ϥΰ}�CV
    public int atk1 = 10;
    public int atk2 = 20;
    public int atk3 = 30;
    //V�ϥΰ}�CV   �b��������᭱�[�W[]
    public int[] atks;

    //�}�C�y�k
    //�}�C�ƶq�����w��
    public float[] speeds = new float[5];
    public string[] props = { "�D��@", "�D��G", "�D��T" };
    public Vector3[] positions = { new Vector3(0, 0, 0), new Vector3(0, 1, 2) };
    public bool[] complete = { true, true, false, false };

    private void Start()
    {
        //1.�}�C�x�s�覡
        //���C�W��[�s��] = ��;
        //�N�}�C�Ĥ@����Ƨאּ100
        atks[0] = 100;
        //2.�ϥΰ}�C�J�쪺���~:�W�X�}�C�d��
        //atks[1] = 100;

        //3.���o�}�C���
        //�}�C�W��[�s��]
        print("�ĤG���D����:" + props[1]);
        print("�ĤG���y�и��:" + positions[1]);
       
        //4.���o�}�C�ƶq Length
        print("���L�Ȱ}�C���ƶq:" + complete.Length);

        //������ɶ����ɥR
        //��0��}�l,�C�@��p�@��,��ܷ�U���
        InvokeRepeating("PrintNumber", 0, 1);
    }

    int number = 1;

    private void PrintNumber()
    {
        print("�Ʀr�G" + number);
        number++;
    }
}

