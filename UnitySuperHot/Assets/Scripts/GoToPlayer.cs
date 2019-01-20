using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToPlayer : MonoBehaviour
{
    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;
    bool _tru = false;
    
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (_navMeshAgent == null)
        {
            Debug.LogError("Problem z dodaniem: " + gameObject.name);
        }
        else
        {
            SetDestination();
        }
    }

    private void FixedUpdate()
    {
        if (_tru)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }

    private void SetDestination()
    {
        if (_destination != null)
        {
            _tru = true;
        }
    }
}