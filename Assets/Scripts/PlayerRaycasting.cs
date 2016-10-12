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
                        player.GetComponent<Inventories>().pressedGFButton = true;
                        Destroy(whatIHit.collider.gameObject);
                    }
                }

                if (whatIHit.collider.tag == "PictureFrames")
                {
                    if (whatIHit.collider.gameObject.GetComponent<PictureFrames>().whatFrameAmI == PictureFrames.PictureFrameID.GFFrame)
                    {
                        if(player.GetComponent<Inventories>().pressedGFButton == true)
                        {
                            Destroy(whatIHit.collider.gameObject);
                        }
                        else
                        {
                            Debug.Log("Press the GF Wall Button");
                        }
                    }
                }
            }
        }
	}
}
