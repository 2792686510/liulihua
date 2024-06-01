using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //刚体
    private Rigidbody rbody;
    void Start()
    {
        //获取玩家角色刚体组件
        rbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //获取水平轴数值
        float horizontal = Input.GetAxis("Horizontal");
        //获取垂直轴数值
        float vertical = Input.GetAxis("Vertical");
        //获取移动方向向量
        Vector3 dir = new Vector3(horizontal, 0, vertical).normalized;
        //给刚体该方向上的速度
        rbody.velocity = dir * 2;
    }
}