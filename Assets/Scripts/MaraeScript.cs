using UnityEngine;
using System.Collections;

public class MaraeScript : MonoBehaviour {

    public Renderer rend;
    public GameObject player;
    public float volume;


    void Start()
    {
        rend = GetComponent<Renderer>();
        player = GameObject.FindWithTag("Player");

    }


    void Update()
    {
        if (player.GetComponent<Inventories>().pressedGFButton == true)
            {
            this.rend.enabled = true;
            gameObject.GetComponentInChildren<AudioSource>().volume = 0.04f;
        }
        else if (player.GetComponent<Inventories>().pressedGFButton == false)
        {
            // hide
            this.rend.enabled = false;
            gameObject.GetComponentInChildren<AudioSource>().volume = 0.0f;
        }
    }
}
