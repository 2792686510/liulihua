using UnityEngine;
using UnityEngine.AI;
public class NPCControl : MonoBehaviour
{
    //导航网格代理组件
    private NavMeshAgent agent;
    //目标点
    private Vector3 targetPos;
    //到达目标点
    private bool isArrived = false;
    void Start()
    {
        //获取导航网格代理组件
        agent = GetComponent<NavMeshAgent>();
        //获取目标点
        targetPos = transform.position + new Vector3(0, 0, 10);
        //向目标点移动
        agent.SetDestination(targetPos);
    }
    //这里我们让角色来回移动
    void Update()
    {
        //获取距离目标点的位置
        float dis = Vector3.Distance(transform.position, targetPos);
        //如果与目标点的距离小于0.1
        if (agent.remainingDistance < 0.1f)
        {
            //重新设置目标点
            if (isArrived)
            {
                //到达起始点
                isArrived = false;
                //设置目标点向前移动
                targetPos = transform.position + new Vector3(0, 0, 10);
            }
            else
            {
                //到达目标点
                isArrived = true;
                //目标点向后移动
                targetPos = transform.position - new Vector3(0, 0, 10);
            }
            //向目标点移动
            agent.SetDestination(targetPos);
        }
    }
}