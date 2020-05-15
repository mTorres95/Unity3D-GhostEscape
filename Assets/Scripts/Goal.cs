using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameObject<Renderer>(material.color) = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)    //call when sth touches the Box Collider 
    {
        if(collision.collider.tag == "Player"){
            SceneManager.LoadScene(0); // it's gonna reload the first scene in the project
        }
    }
}
