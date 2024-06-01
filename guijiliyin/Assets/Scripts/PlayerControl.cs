using UnityEngine;
//导航系统需要的名称空间
using UnityEngine.AI;
public class PlayerControl : MonoBehaviour
{
    //导航网格代理组件
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        //单击鼠标右键
        if (Input.GetMouseButtonDown(1))
        {
            //获取鼠标指针射线
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //碰撞信息
            RaycastHit hit;
            //射线碰撞检测
            bool res = Physics.Raycast(ray, out hit);
            //如果射线碰撞到游戏物体
            if (res)
            {
                //获取碰撞点
                Vector3 point = hit.point;
                //移动到碰撞点，设置导航网格代理的目标位置
                agent.SetDestination(point);
            }
        }
    }
}