using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer), typeof(BoxCollider2D))]
public class Block_Behavior : MonoBehaviour
{
    [Header("Set Block visibility")]
    [SerializeField] private bool visible;

    [HideInInspector] private SpriteRenderer sprite;

    private void Start()
    {
        if (!visible) sprite.enabled = false; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.gameObject.SetActive(false);

    }
}
