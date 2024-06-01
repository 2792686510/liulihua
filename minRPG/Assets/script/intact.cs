using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class intact : MonoBehaviour
{
    //作为父类
    private NavMeshAgent agent = null;
    //标志位
    private bool isAct = false;
    //点击物体的时候
    private float time;
    public void onclick(NavMeshAgent agent)
    {
        this.agent = agent;
        agent.SetDestination(transform.position);//设置移动目标为自己
        agent.stoppingDistance = 1;//距离目标的间隔，防止贴着物体
        isAct = false;
    }
    private void Update()
    {
        if( agent!= null && agent.pathPending == false && isAct==false )
        {//已经计算完了路径
            if(agent.remainingDistance <= 2)
            { //当距离小于2的时候开始交互
                isAct = true;
                act();
            }
        }
    }
    public virtual void act()
    {
        print("进行交互");
    }
}
