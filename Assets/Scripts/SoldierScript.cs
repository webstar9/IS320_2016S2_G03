using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoldierScript : MonoBehaviour
{
    public Vector3 soldierLocation = new Vector3(0, 0, 0);

    void Start()
    {
        soldierLocation = new Vector3(Random.value, Random.value, Random.value);

    }


    void Update()
    {

    }
}
