using UnityEngine;
public class PlayerControl02 : MonoBehaviour
{
    void Update()
    {
        //��ȡˮƽ��
        float horizontal = Input.GetAxis("Horizontal");
        //�ƶ�����
        transform.position += transform.right * horizontal * 0.3f;
    }
}