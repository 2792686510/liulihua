using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //����
    private Rigidbody rbody;
    void Start()
    {
        //��ȡ��ҽ�ɫ�������
        rbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //��ȡˮƽ����ֵ
        float horizontal = Input.GetAxis("Horizontal");
        //��ȡ��ֱ����ֵ
        float vertical = Input.GetAxis("Vertical");
        //��ȡ�ƶ���������
        Vector3 dir = new Vector3(horizontal, 0, vertical).normalized;
        //������÷����ϵ��ٶ�
        rbody.velocity = dir * 2;
    }
}