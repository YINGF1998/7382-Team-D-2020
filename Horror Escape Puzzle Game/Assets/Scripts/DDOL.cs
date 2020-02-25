using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOL : MonoBehaviour
{
    //Here is a file that contains all the necessary data to the game.
    //i.e. saves, achievements, collections, etc...

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
