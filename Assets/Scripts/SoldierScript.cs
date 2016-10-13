using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoldierScript : MonoBehaviour
{
    public Vector3 soldierLocation = new Vector3(0, 0, 0);
    public Renderer rend;
    public GameObject player;
    public float volume;

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
            gameObject.GetComponentInChildren<TextMesh>().characterSize = 0.1f;
            gameObject.GetComponentInChildren<AudioSource>().volume = 0.01f;
        }

        if (player.GetComponent<Inventories>().pressedTFButton == false)
        {
            // hide
            this.rend.enabled = false;
            gameObject.GetComponentInChildren<TextMesh>().characterSize = 0.0f;
            gameObject.GetComponentInChildren<AudioSource>().volume = 0.0f;
        }
    }
}
