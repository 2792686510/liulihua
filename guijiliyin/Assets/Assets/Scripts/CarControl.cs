using UnityEngine;

public class CarControl : MonoBehaviour
{
    //关联两个前轮物体
    public WheelCollider[] frontWheels;
    //关联两个后轮物体
    public WheelCollider[] backWheels;
    void Update()
    {
        //获取水平轴数值
        float horizontal = Input.GetAxis("Horizontal");
        //获取垂直轴数值
        float vertical = Input.GetAxis("Vertical");
        //遍历前轮
        foreach (WheelCollider wheel in frontWheels)
        {
            //给前轮设置最大转弯角度为30。
            wheel.steerAngle = horizontal * 30;
        }
        //遍历后轮
        foreach (WheelCollider wheel in backWheels)
        {
            //给后轮设置最大动力为200
            wheel.motorTorque = vertical * 200;
        }
    }
}