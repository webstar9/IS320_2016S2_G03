using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour {

    public Vector3 spinSpeedBird = new Vector3(0, 0, 0);
    public float rotateSpeedBird = 1.0f;
    Vector3 spinAxisBird = new Vector3(0, 1, 0);
    public Renderer rend;
    public GameObject player;
    public float volume;

    void Start()
    {
        spinSpeedBird = new Vector3(Random.value, Random.value, Random.value);
        spinAxisBird = Vector3.up;
        spinAxisBird.x = (Random.value - Random.value) * .1f; // gives value -1 to +1 //
        rend = GetComponent<Renderer>();
        player = GameObject.FindWithTag("Player");

    }

    public void SetSize(float size)
    {
        this.transform.localScale = new Vector3(size, size, size);
    }

    void Update()
    {
        this.transform.Rotate(spinSpeedBird);
        this.transform.RotateAround(Vector3.zero, spinAxisBird, rotateSpeedBird);

        if (player.GetComponent<Inventories>().pressedFFButton == true)
        {
            // show
            this.rend.enabled = true;
            gameObject.GetComponentInChildren<TextMesh>().characterSize = 1;
            gameObject.GetComponentInChildren<AudioSource>().volume = 0.02f;
        }

        if (player.GetComponent<Inventories>().pressedFFButton == false)
        {
            // hide
            this.rend.enabled = false;
            gameObject.GetComponentInChildren<TextMesh>().characterSize = 0;
            gameObject.GetComponentInChildren<AudioSource>().volume = 0.0f;
        }
    }
}
