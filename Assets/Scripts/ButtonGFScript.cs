using UnityEngine;
using System.Collections;

public class ButtonGFScript : MonoBehaviour
{

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
        if (player.GetComponent<Inventories>().pressedGFButton == true)
        {
            this.rend.sharedMaterial = material2;
        }
        else if (player.GetComponent<Inventories>().pressedGFButton == false)
        {
            this.rend.sharedMaterial = material1;
        }

    }
}