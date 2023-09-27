using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{

    public Transform player;
    public float attackDistance = 3;
    public float speed = 2;

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3();
        var distance = Vector3.Distance(transform.position, player.position);
        if (distance < attackDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }

        transform.forward = moveDirection;
    }
}
