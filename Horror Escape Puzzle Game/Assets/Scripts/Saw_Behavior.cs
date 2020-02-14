using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw_Behavior : MonoBehaviour
{

    #region UnityEditor
    [SerializeField] private enum Behavior { Default, Translate }
    [SerializeField] private Behavior behavior;

    [SerializeField] private Transform[] waypoints;
    [Range(0f,10f)][SerializeField] private float speed;

    [Tooltip("Do you want the Saw to follow the path forever?")]
    [SerializeField] private bool loop = true;

    [HideInInspector] private int targetWaypoint = 0;
    #endregion



    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(behavior.ToString());
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
        switch (behavior)
        {
            case Behavior.Default:
                //Spins at placed location
                break;

            case Behavior.Translate:

                Vector2 direction = (waypoints[targetWaypoint].position - this.gameObject.transform.position).normalized; //Easier to manipulate when normalized.
                Vector2 currentPos = this.gameObject.transform.position;
                Vector2 destination = waypoints[targetWaypoint].position;

                if (Vector2.Distance(currentPos, destination) >= 0.1f)
                {
                    this.gameObject.transform.Translate(direction * speed * Time.deltaTime);
                    //Debug.Log(Vector2.Distance(currentPos, destination));
                }
                else if(targetWaypoint + 1 < waypoints.Length) //prevent index out of range error
                {
                    //Previous waypoint reached. Going to the next one.
                    targetWaypoint++;
                    Debug.Log("Waypoint: " + targetWaypoint);
                }
                else if (targetWaypoint == waypoints.Length - 1 && loop)
                {
                    targetWaypoint = 0;
                    Debug.Log("Waypoint: " + targetWaypoint);
                }
                Debug.DrawRay(currentPos, waypoints[targetWaypoint].position - this.gameObject.transform.position);

                break;

        }
    }


    //TODO Implement the tracks if the Saw tanslates.
    //TODO What if the saw orbits the anchor?

}

