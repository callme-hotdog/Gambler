using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.z = -10;
        Camera.main.transform.position = cameraPosition;

        Vector2 velocity = new Vector2();

        if (Input.GetKeyDown(KeyCode.A))
        {
            velocity.x = -Speed;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            velocity.x = Speed;
        }


    }
}
