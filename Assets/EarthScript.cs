using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        GameObject.Find("GameController").GetComponent<DebrisCounter>().thrown = GameObject.Find("GameController").GetComponent<DebrisCounter>().inhand;
        GameObject.Find("GameController").GetComponent<DebrisCounter>().inhand = 0;
        print("Dumped");

    }
}
