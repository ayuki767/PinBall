using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{        
    float minimum = 1.0f;  // �ŏ��T�C�Y

    float magSpeed = 10.0f; // �g��k���X�s�[�h

    float magnification = 0.07f;�@// �g�嗦
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(minimum + Mathf.Sin(Time.time * magSpeed) * magnification,
            transform.localScale.y, minimum + Mathf.Sin(Time.time * magSpeed) * magnification);
    }
}
