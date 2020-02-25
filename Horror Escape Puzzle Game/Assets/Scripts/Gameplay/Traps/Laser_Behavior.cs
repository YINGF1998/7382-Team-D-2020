using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Behavior : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void Disable() => anim.enabled = false;
}
