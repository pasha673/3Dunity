using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider Other)//����� ����� ������
    {
        Other.GetComponent<FirstPersonMovement>().speed *= speedFactor;
    }


    void OnTriggerExit(Collider Other)//����� ����� �������
    {
        Other.GetComponent<FirstPersonMovement>().speed /= speedFactor;
    }

}
