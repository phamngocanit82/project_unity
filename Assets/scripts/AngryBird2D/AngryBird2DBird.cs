using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryBird2DBird : MonoBehaviour
{
    public bool collided;

    public void Release()
    {
        AngryBird2DPathPoints.instance.Clear();
        StartCoroutine(CreatePathPoints());
    }

    IEnumerator CreatePathPoints()
    {
        while (true)
        {
            if (collided) break;
            AngryBird2DPathPoints.instance.CreateCurrentPathPoint(transform.position);
            yield return new WaitForSeconds(AngryBird2DPathPoints.instance.timeInterval);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collided = true;
    }
}
