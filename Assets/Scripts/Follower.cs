using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follower : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent agent;

    [SerializeField] LayerMask groundLayer, playerLayer;

    [SerializeField] float sightRange;
    bool PlayerInSight;

    void Chase()
    {
        agent.SetDestination(player.transform.position);
    }

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Chase();
    }


}
