using System.Threading;
using UnityEngine;

/// <summary>
///�{�Ѱj��
///while
///do while
///for
///foreach
/// </summary>
public class learnloop : MonoBehaviour
{
    public int[] scores = new int[20];
    //�j�骺�@�� : �Ϥ@�ӫ��O����n��
    private void Start()
    {

        #region while�Mfor���Ϊk
        //�|��:��X����hello����k
        print("hello");
        print("hello");
        print("hello");
        print("hello");
        print("hello");
        //�ϥΰj�骺��k
        //�p�P�ϥ�if����k  if:����k (���L��) {�{���϶�}
        //�ϥ�while����k  while (���L��) {�{���϶�}
        
        //���L�Ȭ�true�ɡA����@��
        if (true)
        {
            print("hi");
        }
        //���L�Ȭ�true�ɡA���ư���  �q���|�L�^��
        /*
        while (true)
        {
            print("hi");        
        }
        */
        int Count = 0;
        while (Count < 5)
        {
            print("�A�n");
            Count++;
        }

        //for(��l��,���L��,�j�鵲�����覡)
        for (int i = 0; i < 5; i++)
        {
            print("�A�|");
        }

        //for ��J100~200���C�j2���Ʀr 
        for (int i = 100; i <201; i+=2)
        {
            print("��J�Ʀr:" + i);
        }
        #endregion
        //�j��P�C�}������
        for (int i = 0; 1<scores.Length; i++)
        {
            scores[i] = 70 + i;

        }
    }
    
    
    
    
}
