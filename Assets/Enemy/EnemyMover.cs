using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] float waitTime = 1f;
    void Start()
    {
     StartCoroutine(FollowPath());  
    }

    IEnumerator FollowPath() // coroutine
    {
    foreach(Waypoint waypoint in path)
        {
            //Debug.Log(waypoint.name);
            this.transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(waitTime); //yield means give up control (here for 1 second)        
        }
    }

}
