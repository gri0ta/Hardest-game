using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;

    public Vector3 spawnPoint;


    private void Start()
    {
        //spawnPoint = transform.position;
    }

    void Update()

    {

        Vector3 moveDirection = new Vector3();
        moveDirection.x = Input.GetAxis("Horizontal"); //replacinom eilutes apacioj
        moveDirection.z = Input.GetAxis("Vertical"); //replacinom eilutes apacioj

        //transform.position += moveDirection * speed * Time.deltaTime;
        GetComponent<Rigidbody>().velocity = moveDirection * speed;

        if (moveDirection != Vector3.zero) transform.forward = moveDirection;

        transform.forward = moveDirection; //rotates player to aswd directions

        
    }

    private void Die()
    {
        transform.position = spawnPoint;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Contains("Enemy") || collision.gameObject.name == "FollowEnemy")
        {
            // Die();
            var currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene);
        }
    }
}


