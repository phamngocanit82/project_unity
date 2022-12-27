using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBrickBall : MonoBehaviour
{
    // Start is called before the first frame update
    public float force = 100;
    bool isPlaying = false;
    Vector3 firstPosition;
    Transform parent;
    void Start()
    {
        firstPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlaying) return;
        if(Input.GetButton("Fire1")){
            transform.parent = null;
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<Rigidbody>().AddForce(force, 0, force);
            isPlaying = true;
        }
    }
    void resetBall(){
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        transform.parent = GameObject.FindGameObjectWithTag("Player").transform;
        transform.localPosition = firstPosition;
        isPlaying = false;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }
    void OnTriggerEnter(){
        resetBall();
    }
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Brick"){
            Destroy(other.gameObject);
        }
    }
}
