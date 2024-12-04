using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bouge : MonoBehaviour
{
    public GameObject agent;
    public Camera MaCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = MaCamera.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == "Plane")
                {
                    agent.GetComponent<NavMeshAgent>().SetDestination(hit.point);
                }
            }
        }
    }
}