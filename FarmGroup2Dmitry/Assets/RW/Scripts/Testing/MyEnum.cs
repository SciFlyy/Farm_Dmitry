using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State { Man = 1, Woman = -1, Gender = 0 }

public enum Days : int
{
  Mondey =  1,


}



public class MyEnum : MonoBehaviour
{
    State state = State.Man;


    enum Presidents { Pytin = 65, Obama = 61, Tramp = 49} // ���������� ������������(��������)

    Presidents myPresident = Presidents.Tramp; // �������� ���������� ������������ � ��������� ��������
    Presidents russionPresident = Presidents.Pytin; //// �������� ��� ������ ���������� ������������

    private void Awake()
    {
        if(myPresident == Presidents.Pytin) //��������� �� ���������(�����)
        {
            print("�����");
        }

        if((int)myPresident >= 60)  // ���������� ��������
        {
            print("������� �����");
        }
        else
        {
            print("�� ������� �����");
        }



















        print(state);
        state = State.Gender;

        int i = (int)state;
        print(i);
    }

    private void Start()
    {
        print(state);
        if (state == State.Man)
        {
            print("���");
        }
        else if (state == State.Woman)
        {
            print("���");
        }
        else if (state == State.Gender)
        {
            print("���");
        }


    }
}
