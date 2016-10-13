using UnityEngine;
using System.Collections;

public class PictureFrameTF : MonoBehaviour {

    public Material material1;
    public Material material2;
    public Renderer rend;
    public GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material1;
    }

    void Update()
    {
        if (player.GetComponent<Inventories>().pressedTFFrame == true)
        {
            this.rend.sharedMaterial = material2;
        }
        else if (player.GetComponent<Inventories>().pressedTFFrame == false)
        {
            this.rend.sharedMaterial = material1;
        }

    }
}
