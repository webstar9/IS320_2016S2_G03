using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour {

    public Vector3 spinSpeedBird = new Vector3(0, 0, 0);
    public float rotateSpeedBird = 1.0f;
    Vector3 spinAxisBird = new Vector3(0, 1, 0);

    void Start()
    {
        spinSpeedBird = new Vector3(Random.value, Random.value, Random.value);
        spinAxisBird = Vector3.up;
        spinAxisBird.x = (Random.value - Random.value) * .1f; // gives value -1 to +1 //

    }

    public void SetSize(float size)
    {
        this.transform.localScale = new Vector3(size, size, size);
    }

    void Update()
    {
        this.transform.Rotate(spinSpeedBird);
        this.transform.RotateAround(Vector3.zero, spinAxisBird, rotateSpeedBird);

    }
}
