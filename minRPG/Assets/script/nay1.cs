using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class nay1 : MonoBehaviour
{
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && EventSystem.current.IsPointerOverGameObject() ==false)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "ground")
                {
                    agent.stoppingDistance = 0;
                    agent.SetDestination(hit.point);
                }else if(hit.collider.tag == "NPC" || hit.collider.tag == "PICK")
                {
                    hit.collider.gameObject.GetComponent<intact>().onclick(agent);
                }
            }
        }
    }
}
