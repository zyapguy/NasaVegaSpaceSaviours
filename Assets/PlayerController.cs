using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 0.0F;

    float speed = 3.5f;

    private void Start() {
        switch(PlayerPrefs.GetString("difficulty"))
        {
            case "Easy":
                speed = 1f;
                break;
            case "Normal":
                speed = 3.5f;
                break;
            case "Hard":
                speed = 7f;
                break;
        }    
    }

    void Update() {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            Cursor.visible = false;
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float v = verticalSpeed * Input.GetAxis("Mouse Y");
            transform.Rotate(v, h, 0);

            
        }
        else {
            Cursor.visible = true;
        }
        float x = Input.GetAxis("Horizontal");
        transform.Rotate(0, x/2, 0);
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
