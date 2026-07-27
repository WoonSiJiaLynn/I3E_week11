using UnityEngine;

public class Chaser : MonoBehaviour
{
    [SerializeField] 
    private Transform targetToChase;

    private UnityEngine.AI.NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        if(navMeshAgent != null)
        {
            navMeshAgent.SetDestination(targetToChase.position);
        }
    }

    void Update()
    {
        if(navMeshAgent != null && targetToChase != null)
        {
            navMeshAgent.SetDestination(targetToChase.position);
        }
    }
}
