using UnityEngine;
using System.Collections;

public class PictureFrames : MonoBehaviour
{

    public enum PictureFrameID { GFFrame, FFFrame, TFFrame };
    public PictureFrameID whatFrameAmI;

    public Material [] material;
    public Renderer rend;
    public GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    void Update()
    {
        if (player.GetComponent<Inventories>().pressedGFButton == true)
        {
            this.rend.sharedMaterial = material[1];
        }
        else
        {
            this.rend.sharedMaterial = material[2];
        }
        if (player.GetComponent<Inventories>().pressedFFButton == true)
        {
            this.rend.sharedMaterial = material[1];
        }
        else
        {
            this.rend.sharedMaterial = material[2];
        }
        if (player.GetComponent<Inventories>().pressedTFButton == true)
        {
            this.rend.sharedMaterial = material[1];
        }
        else
        {
            this.rend.sharedMaterial = material[2];
        }
    }
    }
