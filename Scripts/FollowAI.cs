using UnityEngine;
using UnityEngine.AI;

public class FollowAI : MonoBehaviour
{


    NavMeshAgent agent;

    Animator animator;

    public GameObject ObejctToFollow;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        agent = GetComponent<NavMeshAgent>();

        animator = GetComponent<Animator>();



    }

    // Update is called once per frame
    void Update()
    {


        float distance = Vector3.Distance(transform.position, ObejctToFollow.transform.position); // get the distance 

        if(distance < 5)
        {

            agent.isStopped = true;
            animator.SetInteger("C", 0);



        }
        else if(distance >= 5 && distance < 13)
        {

            // ai walking

            agent.isStopped = false;
            agent.SetDestination(ObejctToFollow.transform.position);

            animator.SetInteger("C", 1);

            agent.speed = 3;



        }
        else if(distance > 13)
        {



            // ai running


            agent.isStopped = false;

            agent.SetDestination(ObejctToFollow.transform.position);

            animator.SetInteger("C", 2);

            agent.speed = 6;



        }




        
    }
}
