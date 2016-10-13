using UnityEngine;
using System.Collections;

public class RatingDislike : MonoBehaviour {

    public Renderer rend;
    public GameObject player;

    void Start()
    {
        rend = GetComponent<Renderer>();
        player = GameObject.FindWithTag("Player");

    }


        void Update()
    {
            if (player.GetComponent<Inventories>().pressedRating == true)
            {
                // show
                if (player.GetComponent<Inventories>().pressedLike == true)
                {
                    this.rend.enabled = false;
                }
                else
                {
                    this.rend.enabled = true;
                }

            }
            else if (player.GetComponent<Inventories>().pressedRating == false)
            {
                // hide
                this.rend.enabled = false;
            }
        }
}
