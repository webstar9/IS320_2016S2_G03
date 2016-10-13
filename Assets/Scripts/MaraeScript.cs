using UnityEngine;
using System.Collections;

public class MaraeScript : MonoBehaviour {

    public Renderer rend;
    public GameObject player;

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
            }
        else if (player.GetComponent<Inventories>().pressedGFButton == false)
        {
            // hide
            this.rend.enabled = false;
        }
    }
}
