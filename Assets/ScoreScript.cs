using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //合計得点
    private int totalScore = 0;


    //スコアを表示するテキスト
    private GameObject scoreText;


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
     
    }

    //衝突時に加算
    void OnCollisionEnter(Collision other)
    {
        //タグによって加算点を変える
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.AddScore(1);
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.AddScore(5);
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.AddScore(50);
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.AddScore(10);
        }
       
    }
    //合計得点に点数を加算する関数
    public void AddScore(int score)
    {
        totalScore += score;
        this.scoreText.GetComponent<Text>().text = " " + totalScore;
    }

}
