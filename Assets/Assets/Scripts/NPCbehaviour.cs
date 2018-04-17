using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCbehaviour : MonoBehaviour {

    public Transform target;

    [Range(0, 3)]
    public float speed;
    public int LifePoints;

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

    private void FixedUpdate()
    {
        life();
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
            animator.SetInteger("Stop", LifePoints);
    }


    void life()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("attack") && LifePoints != 0)
        {
            // TODO: Damage when attacked
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            {
                LifePoints--;
                Debug.Log("Attacked", gameObject);
                Debug.Log("" + LifePoints, gameObject);
            }
        }

        if (LifePoints == 0)
        {
            // TODO: death()
            agent.speed = 0;
            // TODO: Go back to start menu.
        }
    }
}
