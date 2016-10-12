﻿using UnityEngine;
using System.Collections;

public class PlayerRaycasting : MonoBehaviour {

    public float distanceToSee;
    RaycastHit whatIHit;
    public GameObject player;
    public 


	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.magenta);

        if(Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
        {
            if(Input.GetKeyDown (KeyCode.E))
            {
                Debug.Log("I pressed button " + whatIHit.collider.gameObject.name);
                if (whatIHit.collider.tag == "Buttons")
                {
                    if (whatIHit.collider.gameObject.GetComponent<ButtonScript>().whatButtonAmI == ButtonScript.ButtonID.GF)
                    {
                        player.GetComponent<Inventories>().pressedGFButton = true;
                    }
                    else if (whatIHit.collider.gameObject.GetComponent<ButtonScript>().whatButtonAmI == ButtonScript.ButtonID.FF)
                    {
                        player.GetComponent<Inventories>().pressedFFButton = true;
                    }
                    else if (whatIHit.collider.gameObject.GetComponent<ButtonScript>().whatButtonAmI == ButtonScript.ButtonID.TF)
                    {
                        player.GetComponent<Inventories>().pressedTFButton = true;
                    }
                }

                if (whatIHit.collider.tag == "PictureFrames")
                {
                    if (whatIHit.collider.gameObject.GetComponent<PictureFrames>().whatFrameAmI == PictureFrames.PictureFrameID.GFFrame)
                    {
                        if(player.GetComponent<Inventories>().pressedGFButton == true)
                        {
                            Debug.Log("I'm clicking on the GF Picture Frame");
                        }
                        else
                        {
                            Debug.Log("Press the GF Wall Button");
                        }
                    }
                    else if (whatIHit.collider.gameObject.GetComponent<PictureFrames>().whatFrameAmI == PictureFrames.PictureFrameID.FFFrame)
                    {
                        if (player.GetComponent<Inventories>().pressedFFButton == true)
                        {
                            Debug.Log("I'm clicking on the FF Picture Frame");
                        }
                        else
                        {
                            Debug.Log("Press the FF Wall Button");
                        }
                    }
                    else if (whatIHit.collider.gameObject.GetComponent<PictureFrames>().whatFrameAmI == PictureFrames.PictureFrameID.TFFrame)
                    {
                        if (player.GetComponent<Inventories>().pressedTFButton == true)
                        {
                            Debug.Log("I'm clicking on the TF Picture Frame");
                        }
                        else
                        {
                            Debug.Log("Press the TF Wall Button");
                        }
                    }
                }
            }
        }
	}
}
