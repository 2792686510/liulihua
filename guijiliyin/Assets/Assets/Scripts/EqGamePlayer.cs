using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqGamePlayer : MonoBehaviour
{
    //����
    private Rigidbody rbody;
    //�Ե��Ľ�Ҹ���
    private int CoinCount;

    void Start()
    {
        //��ȡ�������
        rbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //��ȡˮƽ����ֵ
        float horizontal = Input.GetAxis("Horizontal");
        //��ȡ��ֱ����ֵ
        float vertical = Input.GetAxis("Vertical");
        //�ƶ���������
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        //����������ڣ�֤�����ǰ����˼����ϵķ����
        if (dir != Vector3.zero)
        {
            //ת�������
            transform.rotation = Quaternion.LookRotation(dir);
            //��ǰ���ƶ�
            rbody.velocity = 3 * dir.normalized;
        }
        else
        {
            //ֹͣ�ƶ�
            rbody.velocity = Vector3.zero;
        }
    }

    //������ײ
    private void OnCollisionEnter(Collision collision)
    {
        //�����������ǽ��
        if (collision.collider.tag == "Wall")
        {
            //��Ϸ����
            Debug.Log("��Ϸʧ�ܣ���Ϸ����");
            //��Ϸֹͣ
            Time.timeScale = 0;
        }
    }

    //���ӽ�ҷ���
    public void AddCoin()
    {
        //����һö���
        CoinCount++;
        //����Թ���5ö���
        if (CoinCount >= 5)
        {
            //��Ϸ����
            Debug.Log("��Ϸʤ������Ϸ����");
            //��Ϸֹͣ
            Time.timeScale = 0;
        }
    }

}
