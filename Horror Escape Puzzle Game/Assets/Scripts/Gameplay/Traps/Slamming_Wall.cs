using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]

public class Slamming_Wall : MonoBehaviour
{
    [Tooltip("Add the sensor object here.")]
    [SerializeField] private GameObject SensorObject;

    //Choose in which direction to slam the wall
    public enum Directions { Up, Down, Left, Right }
    public Directions enumDirection;
    [HideInInspector] private Vector2 v2Direction;

    [HideInInspector] private Vector2 originalPos;

    [Range(1f, 5f)] 
    [SerializeField] private float speed;

    [Header("Reset Position Timer")]
    [Tooltip("Time that takes to call the reset position function.")]
    [Range(0f, 5f)] 
    [SerializeField] private float resetTimer;


    [SerializeField] private Wall_Sensor script; 

    // Start is called before the first frame update
    private void Start()
    {
        //Saves starting position
        originalPos = this.gameObject.transform.position;

        //Picks the right direction
        switch (enumDirection)
        {
            case Directions.Up:
                v2Direction = Vector2.up;
                break;

            case Directions.Down:
                v2Direction = Vector2.down;
                break;

            case Directions.Left:
                v2Direction = Vector2.left;
                break;

            case Directions.Right:
                v2Direction = Vector2.right;
                break;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("ResetPosition", resetTimer);
    }

    private void ResetPosition()
    {
        Vector2 direction = originalPos - (Vector2)this.gameObject.transform.position;
        this.gameObject.transform.Translate(direction * speed * Time.deltaTime);
    }

    public Vector2 Direction => this.v2Direction;
    public float Speed => this.speed;
}
