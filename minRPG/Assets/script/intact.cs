using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class intact : MonoBehaviour
{
    //��Ϊ����
    private NavMeshAgent agent = null;
    //��־λ
    private bool isAct = false;
    //��������ʱ��
    private float time;
    public void onclick(NavMeshAgent agent)
    {
        this.agent = agent;
        agent.SetDestination(transform.position);//�����ƶ�Ŀ��Ϊ�Լ�
        agent.stoppingDistance = 1;//����Ŀ��ļ������ֹ��������
        isAct = false;
    }
    private void Update()
    {
        if( agent!= null && agent.pathPending == false && isAct==false )
        {//�Ѿ���������·��
            if(agent.remainingDistance <= 2)
            { //������С��2��ʱ��ʼ����
                isAct = true;
                act();
            }
        }
    }
    public virtual void act()
    {
        print("���н���");
    }
}
