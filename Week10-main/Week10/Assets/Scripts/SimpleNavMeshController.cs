using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleNavMeshController : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent _agent;
    public Camera _camera = null;
    // Start is called before the first frame update
    void Start()
    {

        _camera = GameObject.Find("Main Camera").GetComponent<Camera>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit))
            {
                _agent.SetDestination(hit.point);
            }
        }
    }
}
