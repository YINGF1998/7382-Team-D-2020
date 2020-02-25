using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoad : MonoBehaviour
{
    private Vector2 lastCheckpoint;
    [SerializeField] GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Waypoint")
        {
            lastCheckpoint = collision.transform.position;
        }
    }

    public void Save()
    {
        PlayerPrefs.SetString("Last Checkpoint", SceneManager.GetActiveScene().name);
    }

    public void LoadLastCheckpoint()
    {
        //SceneManager.LoadScene(PlayerPrefs.GetString("Last Checkpoint"));
        Player.transform.position = lastCheckpoint;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
