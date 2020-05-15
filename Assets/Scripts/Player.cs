using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // To move the cube a bit faster
    [SerializeField]           // make sure it's seralizable. Shows up in the inspector
    private float speed = 5;

    // Update is called once per frame
    // FixedUpdate stops the player from "vibrating" when colliding
    // with an object and partially going "in" that objet
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");        
        float vertical = Input.GetAxis("Vertical");
        
        // Using only x and z, doesn't change in y (higher or lower than the plane) 
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        // (*Time.delta) to be independant of the frames
        transform.position += movement * Time.deltaTime * speed;
    }

    // Cube (player) dies when touched by ghosts (capsule)
    private void OnCollisionEnter(Collision collision)    //call when sth touches the Box Collider 
    {
        if(collision.collider.tag == "Ghost"){
            SceneManager.LoadScene(0); // it's gonna reload the first scene in the project
        }
    }
}
