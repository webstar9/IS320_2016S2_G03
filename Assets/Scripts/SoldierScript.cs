using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoldierScript : MonoBehaviour
{
    public Vector3 soldierLocation = new Vector3(0, 0, 0);
    public Renderer rend;
    public GameObject player;

    void Start()
    {
        soldierLocation = new Vector3(Random.value, Random.value, Random.value);
        rend = GetComponent<Renderer>();
        player = GameObject.FindWithTag("Player");

    }

    void Update()
    {
        if (player.GetComponent<Inventories>().pressedTFButton == true)
        {
            // show
            this.rend.enabled = true;
        }

        if (player.GetComponent<Inventories>().pressedTFButton == false)
        {
            // hide
            this.rend.enabled = false;
        }
    }
}
