using UnityEngine;

public class CarControl : MonoBehaviour
{
    //��������ǰ������
    public WheelCollider[] frontWheels;
    //����������������
    public WheelCollider[] backWheels;
    void Update()
    {
        //��ȡˮƽ����ֵ
        float horizontal = Input.GetAxis("Horizontal");
        //��ȡ��ֱ����ֵ
        float vertical = Input.GetAxis("Vertical");
        //����ǰ��
        foreach (WheelCollider wheel in frontWheels)
        {
            //��ǰ���������ת��Ƕ�Ϊ30��
            wheel.steerAngle = horizontal * 30;
        }
        //��������
        foreach (WheelCollider wheel in backWheels)
        {
            //���������������Ϊ200
            wheel.motorTorque = vertical * 200;
        }
    }
}