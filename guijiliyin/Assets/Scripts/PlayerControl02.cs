using UnityEngine;
public class PlayerControl02 : MonoBehaviour
{
    void Update()
    {
        //获取水平轴
        float horizontal = Input.GetAxis("Horizontal");
        //移动自身
        transform.position += transform.right * horizontal * 0.3f;
    }
}