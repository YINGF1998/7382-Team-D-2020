using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behavior : MonoBehaviour, IDeath
{



    public void Death()
    {
        Debug.Log("player death");
        //if only collision with spikes - gets stuck at that position and piss blood
        //if trigger enter on fire/lava/laser - gets fried to a crisp
        //if bomb vest explodes - blood flies everywhere + screen shake?
    }
}
