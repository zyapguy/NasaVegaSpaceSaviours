using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{
    public GameObject toSpawn;
    public int amount;
    // Start is called before the first frame update
    void Start()
    {
        switch(PlayerPrefs.GetString("difficulty"))
        {
            case "Easy":
                amount = 20;
                break;
            case "Normal":
                amount = 100;
                break;
            case "Hard":
                amount = 250;
                break;
        }    
        GetComponent<Renderer>().enabled = false;
        for (int i = 0; i < amount; i++)
        {
            Instantiate(toSpawn, new Vector3(
                Random.Range(transform.position.x - transform.localScale.x / 2, transform.position.x + transform.localScale.x / 2),
                Random.Range(transform.position.y - transform.localScale.y / 2, transform.position.y + transform.localScale.y / 2),
                Random.Range(transform.position.z - transform.localScale.z / 2, transform.position.z + transform.localScale.z / 2)
            ),Quaternion.Euler(Random.Range(0,360),Random.Range(0,360),Random.Range(0,360)));
        }
    }
}
