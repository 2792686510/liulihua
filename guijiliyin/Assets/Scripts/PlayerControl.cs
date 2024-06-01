using UnityEngine;
//����ϵͳ��Ҫ�����ƿռ�
using UnityEngine.AI;
public class PlayerControl : MonoBehaviour
{
    //��������������
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        //��������Ҽ�
        if (Input.GetMouseButtonDown(1))
        {
            //��ȡ���ָ������
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //��ײ��Ϣ
            RaycastHit hit;
            //������ײ���
            bool res = Physics.Raycast(ray, out hit);
            //���������ײ����Ϸ����
            if (res)
            {
                //��ȡ��ײ��
                Vector3 point = hit.point;
                //�ƶ�����ײ�㣬���õ�����������Ŀ��λ��
                agent.SetDestination(point);
            }
        }
    }
}