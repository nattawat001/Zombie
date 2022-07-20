using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public GameObject player;
    NavMeshAgent agent;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Float dist = Vector3.Distance(transform.position, player.transform.position);
        anim.SetFloat("distance", dist);
        if (dist < 2.5f) agent.speed = 0;
        else agent.SetDestination(player.transform.position);
    }
}
