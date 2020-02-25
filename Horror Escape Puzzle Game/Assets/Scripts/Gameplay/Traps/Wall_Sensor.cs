using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class Wall_Sensor : MonoBehaviour
{

    [SerializeField] private Slamming_Wall wall;


    // This is for when the target enters the zone.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")) this.gameObject.transform.Translate(wall.Direction * wall.Speed * Time.deltaTime);
    }

}
