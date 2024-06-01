using UnityEngine;
using UnityEngine.AI;
public class NPCControl : MonoBehaviour
{
    //��������������
    private NavMeshAgent agent;
    //Ŀ���
    private Vector3 targetPos;
    //����Ŀ���
    private bool isArrived = false;
    void Start()
    {
        //��ȡ��������������
        agent = GetComponent<NavMeshAgent>();
        //��ȡĿ���
        targetPos = transform.position + new Vector3(0, 0, 10);
        //��Ŀ����ƶ�
        agent.SetDestination(targetPos);
    }
    //���������ý�ɫ�����ƶ�
    void Update()
    {
        //��ȡ����Ŀ����λ��
        float dis = Vector3.Distance(transform.position, targetPos);
        //�����Ŀ���ľ���С��0.1
        if (agent.remainingDistance < 0.1f)
        {
            //��������Ŀ���
            if (isArrived)
            {
                //������ʼ��
                isArrived = false;
                //����Ŀ�����ǰ�ƶ�
                targetPos = transform.position + new Vector3(0, 0, 10);
            }
            else
            {
                //����Ŀ���
                isArrived = true;
                //Ŀ�������ƶ�
                targetPos = transform.position - new Vector3(0, 0, 10);
            }
            //��Ŀ����ƶ�
            agent.SetDestination(targetPos);
        }
    }
}