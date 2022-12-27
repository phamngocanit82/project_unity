using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileProjection3DScreenshake : MonoBehaviour
{
    public static float ShakeAmount = 0;
    Vector3 StartingPosition;

    void Start()
    {
        StartingPosition = transform.position;
    }

    void Update()
    {
        ShakeAmount = Mathf.Lerp(ShakeAmount, 0, 0.02f);
        transform.position = StartingPosition + Random.onUnitSphere * ShakeAmount;
    }
}
