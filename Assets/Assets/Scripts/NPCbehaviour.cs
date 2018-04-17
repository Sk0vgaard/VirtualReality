using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCbehaviour : MonoBehaviour {

    public Transform target;

    [Range(0, 3)]
    public float speed;
    public int HitPoints;

    public float distToTarget;

    private Animator animator;
    private NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        agent.speed = speed;
        distToTarget = Vector3.Distance(transform.position, target.position);
        if (distToTarget > 2f)
        {
            agent.isStopped = false;
            agent.SetDestination(target.position);
        }
        else
        {
            agent.isStopped = true;
        }
        animator.SetFloat("Forward", agent.velocity.magnitude);

        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("attack"))
        {
            // TODO: Damage when attacked
            HitPoints = HitPoints--;
        }

        if (HitPoints == 0)
        {
            Debug.Log("YESSSS", gameObject);
            // TODO: Go back to start menu.
        }
    }
}
