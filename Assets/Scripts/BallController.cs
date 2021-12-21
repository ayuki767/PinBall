using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    float visiblePosZ = -6.5f;

    int score = 0;

    GameObject gameoverText;
    GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        gameoverText = GameObject.Find("GameOverText");
        scoreText = GameObject.Find("ScoreText");      
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score : " + score.ToString();

        if(transform.position.z < visiblePosZ)
        {
            gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag" || other.gameObject.tag == "SmallCloudTag")
        {
            score += 10;
        }
        else if(other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "LargeCloudTag")
        {
            score += 20;
        }
    }
}
