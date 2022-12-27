using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBrickBrick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnDestroy(){
        GameObject flare = Instantiate(particle, transform.position, Quaternion.identity) as GameObject;
        Destroy(flare,2);
    }
}
