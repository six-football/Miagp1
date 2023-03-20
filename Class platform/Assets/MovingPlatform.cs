using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform[] platformPosistion = new Transform[3];
    int direction = 1;
    public float speed;
    Vector2 target;
    void Update()
    {
        target = currentMovementTarget();

        platformPosistion[0].position = Vector2.Lerp(platformPosistion[0].position, target, speed * Time.deltaTime);
        float distance = (target - (Vector2)platformPosistion[0].position).magnitude;

        if (distance <= .5f)
        {
            direction *= -1;
        }
    }

}

