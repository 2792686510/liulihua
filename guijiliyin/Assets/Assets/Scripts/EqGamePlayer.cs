using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqGamePlayer : MonoBehaviour
{
    //刚体
    private Rigidbody rbody;
    //吃到的金币个数
    private int CoinCount;

    void Start()
    {
        //获取刚体组件
        rbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //获取水平轴数值
        float horizontal = Input.GetAxis("Horizontal");
        //获取垂直轴数值
        float vertical = Input.GetAxis("Vertical");
        //移动方向向量
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        //如果向量存在，证明我们按下了键盘上的方向键
        if (dir != Vector3.zero)
        {
            //转向该向量
            transform.rotation = Quaternion.LookRotation(dir);
            //向前方移动
            rbody.velocity = 3 * dir.normalized;
        }
        else
        {
            //停止移动
            rbody.velocity = Vector3.zero;
        }
    }

    //发生碰撞
    private void OnCollisionEnter(Collision collision)
    {
        //如果碰到的是墙壁
        if (collision.collider.tag == "Wall")
        {
            //游戏结束
            Debug.Log("游戏失败，游戏结束");
            //游戏停止
            Time.timeScale = 0;
        }
    }

    //增加金币方法
    public void AddCoin()
    {
        //增加一枚金币
        CoinCount++;
        //如果吃够了5枚金币
        if (CoinCount >= 5)
        {
            //游戏结束
            Debug.Log("游戏胜利，游戏结束");
            //游戏停止
            Time.timeScale = 0;
        }
    }

}
