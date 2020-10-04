using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        GameObject.Find("GameController").GetComponent<DebrisCounter>().AddScore();
        Destroy(gameObject);
    }
}
