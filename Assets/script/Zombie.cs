using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    NavMeshAgent agen;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        agen = GetComponent<NavMeshAgent>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,Player.transform.position)<1.5f)
        {
            agen.speed = 0;
        }
        else agen.SetDestination(Player.transform.position);
    }
}
