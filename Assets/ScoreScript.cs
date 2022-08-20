using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //���v���_
    private int totalScore = 0;


    //�X�R�A��\������e�L�X�g
    private GameObject scoreText;


    // Start is called before the first frame update
    void Start()
    {
        //ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");
        //Score��\��
        this.scoreText.GetComponent<Text>().text = " "+ totalScore;

    }

    // Update is called once per frame
    void Update()
    {
     
    }

    //�Փˎ��ɉ��Z
    void OnCollisionEnter(Collision other)
    {
        //�^�O�ɂ���ĉ��Z�_��ς���
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
    //���v���_�ɓ_�������Z����֐�
    public void AddScore(int score)
    {
        totalScore += score;
        this.scoreText.GetComponent<Text>().text = " " + totalScore;
    }

}
