using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //合計得点
    private int totalScore = 0;

    //加算点
    private int addScore = 0;

    //スコアを表示するテキスト
    private GameObject scoreText;

    private int degree = 0;

    // Start is called before the first frame update
    void Start()
    {
        //ScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
        //Scoreを表示
        this.scoreText.GetComponent<Text>().text = " "+ totalScore;

    }

    // Update is called once per frame
    void Update()
    {
        //Scoreを表示
        this.scoreText.GetComponent<Text>().text = " " + totalScore;
    }

    //衝突時に加算
    void OnCollisionEnter(Collision other)
    {
        //タグによって加算点を変える
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.addScore = 1;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.addScore = 5;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.addScore = 50;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.addScore = 10;
        }
        //合計得点に点数を加算
        totalScore += addScore;
        //addScoreリセット
        this.addScore = 0;
    }
}
