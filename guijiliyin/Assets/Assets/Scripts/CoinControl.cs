using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //�жϴ������ǲ������
        if (other.tag == "Player")
        {
            //����һö���
            other.GetComponent<EqGamePlayer>().AddCoin();
            //ɾ���Լ�
            Destroy(gameObject);
        }
    }
}
