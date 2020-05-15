using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Position the walls randomly on z-axis, making sure they're within the room
        float zPosMax = 7.5F - 2; 
        float zPosMin = -7.5F + 2;
        float randomZposition = UnityEngine.Random.Range(zPosMin,zPosMax);
    
        Vector3 wallPosition = new Vector3(transform.position.x, transform.position.y, randomZposition);
        transform.position = wallPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
