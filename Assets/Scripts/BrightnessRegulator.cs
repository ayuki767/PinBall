using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour
{
    Material myMaterial;

    float minEmission = 0.2f;
    float magEmission = 2.0f;

    int degree = 0;
    int speed = 5;

    Color defaultColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        if(tag == "SmallStarTag")
        {
            defaultColor = Color.white;
        }
        else if(tag == "LargeStarTag")
        {
            defaultColor = Color.yellow;
        }
        else if(tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            defaultColor = Color.cyan;
        }
        myMaterial = GetComponent<Renderer>().material;

        myMaterial.SetColor("_EmissionColor", defaultColor * minEmission);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(degree >= 0)
        {
            Color emissionColor = defaultColor * (minEmission + Mathf.Sin(degree * Mathf.Deg2Rad) * magEmission);

            myMaterial.SetColor("_EmissionColor", emissionColor);

            degree -= speed;
        }
        
    }

    void OnCollisionEnter(Collision other)
    {
        degree = 180;
    }
}
