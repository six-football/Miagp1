using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    //Reference to waypoints
    public List<Transform> points;
    //creates an int that will represent our indexed transforms in our list
    public int nextId;
    // help us change our nextId value
    private int idChangevalue = 1;

    // Update is called once per frame
    private void Update()
    {

    }

    void MoveToNextPoints()
    {  //Declare and set a transform to our point
        Transform goalpoints = points[nextId];
        //Flip the enemy via the transform to look at the points direction
        //Might need to change based off of the sprites natural face

        Transform goalPoint = points[nextId];
        if (goalPoint.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1,);
      
        }
    } 



}
