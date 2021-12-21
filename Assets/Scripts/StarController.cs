using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    float rotSpeed = 0.5f; // ‰ñ“]‘¬“x

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotSpeed, 0);
    }
}
