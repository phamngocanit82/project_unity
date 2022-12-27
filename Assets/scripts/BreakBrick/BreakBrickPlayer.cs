using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBrickPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3;
    Vector3 playerPosition;
    void Start()
    {
        playerPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x =  transform.position.x + Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        Vector3 newPosition = new Vector3(Mathf.Clamp(x, -4, 4), playerPosition.y, playerPosition.z); 
        transform.position = newPosition;
    }
}
