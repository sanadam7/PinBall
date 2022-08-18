using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;

    //�����̌X��
    private float defaultAngle = 20;
    //�e�����Ƃ��̌X��
    private float flickAngle = -20;


    // Start is called before the first frame update
    void Start()
    {
        //HingerJoint�R���|�[�l���g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {
        //�����L�[���������Ƃ����t���b�p�[�𓮂���
        if(Input.GetKeyDown(KeyCode.LeftArrow)&& tag =="LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //�E���L�[���������Ƃ��E�t���b�p�[�𓮂���
        if(Input.GetKeyDown(KeyCode.RightArrow)&& tag =="RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //���L�[�����ꂽ�Ƃ��t���b�p�[�����ɖ߂�
        if(Input.GetKeyUp(KeyCode.LeftArrow)&& tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if(Input.GetKeyUp(KeyCode.RightArrow)&& tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
    }
    //�t���b�p�[�̌X����ݒ肷��֐�
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }

}
