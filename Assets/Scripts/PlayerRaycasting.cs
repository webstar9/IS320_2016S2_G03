using UnityEngine;
using System.Collections;

public class PlayerRaycasting : MonoBehaviour {

    public float distanceToSee;
    RaycastHit whatIHit;
    public GameObject player;

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
                        if(player.GetComponent<Inventories>().pressedGFButton == false)
                        {
                            player.GetComponent<Inventories>().pressedGFButton = true;
                        }
                        else
                        {
                            player.GetComponent<Inventories>().pressedGFButton = false;
                        }

                    }
                    else if (whatIHit.collider.gameObject.GetComponent<ButtonScript>().whatButtonAmI == ButtonScript.ButtonID.FF)
                    {
                        if (player.GetComponent<Inventories>().pressedFFButton == false)
                        {
                            player.GetComponent<Inventories>().pressedFFButton = true;
                        }
                        else
                        {
                            player.GetComponent<Inventories>().pressedFFButton = false;
                        }
                    }
                    else if (whatIHit.collider.gameObject.GetComponent<ButtonScript>().whatButtonAmI == ButtonScript.ButtonID.TF)
                    {
                        if (player.GetComponent<Inventories>().pressedTFButton == false)
                        {
                            player.GetComponent<Inventories>().pressedTFButton = true;
                        }
                        else
                        {
                            player.GetComponent<Inventories>().pressedTFButton = false;
                        }
                    }
                }

                if (whatIHit.collider.tag == "Maps")
                {
                    if (whatIHit.collider.gameObject.GetComponent<PictureFrames>().whatFrameAmI == PictureFrames.PictureFrameID.GFFrame)
                    {
                        if(player.GetComponent<Inventories>().pressedGFFrame == true)
                        {
                            player.GetComponent<Inventories>().pressedGFFrame = false;
                        }
                        else
                        {
                            player.GetComponent<Inventories>().pressedGFFrame = true;
                        }
                    }
                    else if (whatIHit.collider.gameObject.GetComponent<PictureFrames>().whatFrameAmI == PictureFrames.PictureFrameID.FFFrame)
                    {
                        if (player.GetComponent<Inventories>().pressedFFFrame == true)
                        {
                            player.GetComponent<Inventories>().pressedFFFrame = false;
                        }
                        else
                        {
                            player.GetComponent<Inventories>().pressedFFFrame = true;
                        }
                    }
                    else if (whatIHit.collider.gameObject.GetComponent<PictureFrames>().whatFrameAmI == PictureFrames.PictureFrameID.TFFrame)
                    {
                        if (player.GetComponent<Inventories>().pressedTFFrame == true)
                        {
                            player.GetComponent<Inventories>().pressedTFFrame = false;
                        }
                        else
                        {
                            player.GetComponent<Inventories>().pressedTFFrame = true;
                        }
                    }
                }
            }
        }
	}
}
